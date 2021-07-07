using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ETPro
{
    class OrderDayCombox:ComboBox
    {
        public OrderDayCombox()
        {
            ComboBoxItem item = new ComboBoxItem();
            CheckBox ck = new CheckBox();
            ck.Content = ETPro.Properties.Resources.Monday;
            item.Content = ck;
            ck.Checked += Ck_Checked;
            ck.Unchecked += Ck_Checked;
            Items.Add(item);

            item = new ComboBoxItem();
            ck = new CheckBox();
            ck.Content = ETPro.Properties.Resources.Tuesday;
            item.Content = ck;
            ck.Checked += Ck_Checked;
            ck.Unchecked += Ck_Checked;
            Items.Add(item);

            item = new ComboBoxItem();
            ck = new CheckBox();
            ck.Content = ETPro.Properties.Resources.Wednesday;
            item.Content = ck;
            ck.Checked += Ck_Checked;
            ck.Unchecked += Ck_Checked;
            Items.Add(item);

            item = new ComboBoxItem();
            ck = new CheckBox();
            ck.Content = ETPro.Properties.Resources.Thursday;
            item.Content = ck;
            ck.Checked += Ck_Checked;
            ck.Unchecked += Ck_Checked;
            Items.Add(item);

            item = new ComboBoxItem();
            ck = new CheckBox();
            ck.Content = ETPro.Properties.Resources.Saturday;
            item.Content = ck;
            ck.Checked += Ck_Checked;
            ck.Unchecked += Ck_Checked;
            Items.Add(item);

            item = new ComboBoxItem();
            ck = new CheckBox();
            ck.Content = ETPro.Properties.Resources.Sunday;
            item.Content = ck;
            ck.Checked += Ck_Checked;
            ck.Unchecked += Ck_Checked;
            Items.Add(item);
        }

        private void Ck_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            if(sender is CheckBox ck)
            {
                if(ck.IsChecked.Value)
                {
                    if (Text.Contains(ck.Content.ToString()))
                        return;
                    Text += ck.Content.ToString()+",";
                }
                else
                {
                    if (!Text.Contains(ck.Content.ToString()))
                        return;
                    Text = Text.Replace(ck.Content.ToString()+",", "");
                }
            }
        }

    }


}
