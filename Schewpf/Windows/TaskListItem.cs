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
        public Button RemoveButton { get; private set; }

        public TaskListItem(Task task, bool check, RoutedEventHandler checkd, RoutedEventHandler removed)
        {
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(130) });
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(50) });
            ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(20) });

            Task = task;

            CheckBox = new CheckBox
            {
                IsChecked = check,
                Content = task.DateTime.ToString("yy.MM.dd.") + "\t" + task.Title
            };
            CheckBox.Checked += checkd;
            CheckBox.Unchecked += checkd;

            RemoveButton = new Button() 
            {
                Content = "X",
                Background = new SolidColorBrush(Colors.White),
            };
            RemoveButton.Click += removed;
            
            Children.Add(CheckBox);
            Children.Add(RemoveButton);

            Width = 200;
            Grid.SetColumn(RemoveButton, 2);
        }
    }
}
