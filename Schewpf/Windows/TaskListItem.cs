using Schewpf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Schewpf.Windows
{
    public class TaskListItem : Grid
    {
        public Task Task { get; private set; }
        public CheckBox CheckBox { get; private set; }
        public Label Label { get; private set; }
        public Button RemoveButton { get; private set; }

        public TaskListItem(Task task, bool check, RoutedEventHandler checkd, RoutedEventHandler removed)
        {
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(25) });
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(150) });
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(25) });

            Width = 200;
            Task = task;

            CheckBox = new CheckBox()
            {
                IsChecked = check,
                VerticalAlignment = VerticalAlignment.Center,
            };
            CheckBox.Checked += checkd;
            CheckBox.Unchecked += checkd;

            Label = new Label()
            {
                Content = task.DateTime.ToString("yy.MM.dd.") + " " + task.Title,
                VerticalAlignment = VerticalAlignment.Center,
            };

            RemoveButton = new Button() 
            {
                Content = "🗑",
                Foreground = new SolidColorBrush(Colors.White),
                Background = new SolidColorBrush(Colors.DarkRed),
            };
            RemoveButton.Click += removed;
            
            Children.Add(CheckBox);
            Children.Add(Label);
            Children.Add(RemoveButton);

            Grid.SetColumn(Label, 1);
            Grid.SetColumn(RemoveButton, 2);
        }
    }
}
