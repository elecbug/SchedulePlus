using Scheduler.CustomControls;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Scheduler
{
    public class DataBook
    {
        public List<Todo> Todos { get; private set; } = new List<Todo>();
        public List<string> Memos { get; private set; } = new List<string>();
        public byte[] Pass { get; private set; } = new byte[0];

        public void SetPass(string text)
        {
            this.Pass = SHA256.HashData(Encoding.UTF8.GetBytes(text));
        }

        public void Load(string path, bool usedAES) 
        {
            string[] texts;

            if (usedAES == false)
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    texts = reader.ReadToEnd().Split("\r\n");
                }
            }
            else
            {
                while (true)
                {
                    HintTextBox passBox = new HintTextBox();
                    passBox.Multiline = false;

                    AddForm form = new AddForm(new Pair[]
                    {
                    new Pair("PASSWORD", passBox),
                    });

                    if (form.ShowDialog() == DialogResult.Cancel)
                    {
                        byte[] pass = SHA256.HashData(Encoding.UTF8.GetBytes(passBox.Text));
                        byte[] enc;

                        using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
                        {
                            enc = reader.ReadBytes((int)new FileInfo(path).Length);
                        }

                        Aes aes = Aes.Create();
                        aes.Key = pass;
                        aes.BlockSize = 128;
                        try
                        {
                            byte[] dec = aes.DecryptCbc(enc, pass[0..16]);
                            texts = Encoding.UTF8.GetString(dec).Split("\r\n");

                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Invalid password!");

                            Debug.WriteLine(ex);
                            continue;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can password!");

                        continue;
                    }
                }
            }

            this.Todos = JsonSerializer.Deserialize<List<Todo>>(texts[0]) ?? new List<Todo>();
            this.Memos = JsonSerializer.Deserialize<List<string>>(texts[1]) ?? new List<string>();
            this.Pass = JsonSerializer.Deserialize<byte[]>(texts[2]) ?? new byte[0];
        }

        public void Save(string path, bool usedAES)
        {
            string texts = 
                JsonSerializer.Serialize(this.Todos) + "\r\n" + 
                JsonSerializer.Serialize(this.Memos) + "\r\n" + 
                JsonSerializer.Serialize(this.Pass);

            if (usedAES == false)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(texts);
                }
            }
            else
            {
                Aes aes = Aes.Create();
                aes.Key = this.Pass;
                aes.BlockSize = 128;
                byte[] enc = aes.EncryptCbc(Encoding.UTF8.GetBytes(texts), this.Pass[0..16]);

                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(path)))
                {
                    writer.Write(enc);
                }
            }
        }
    }
}
