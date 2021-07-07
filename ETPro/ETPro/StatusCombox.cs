using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ETPro
{
    public class StatusCombox:ComboBox
    {
        private CheckBox ckOrdIsActive = new CheckBox();
        private CheckBox ckOrdIfExtraHours = new CheckBox();
        private CheckBox ckIsChecked = new CheckBox();
        private CheckBox ckIsApproved = new CheckBox();
        private CheckBox ckIsFinished = new CheckBox();
        private CheckBox ckIsFeeChecked = new CheckBox();
        private CheckBox ckIsMarkedOk = new CheckBox();
        private CheckBox ckIsDoneOk = new CheckBox();
        private CheckBox ckIsPayed = new CheckBox();
        private CheckBox ckIsReadOnly = new CheckBox();

        public bool OrdIsActive { get => ckOrdIsActive.IsChecked.Value; }
        public bool OrdIfExtraHours { get => ckOrdIfExtraHours.IsChecked.Value; }
        public bool IsChecked { get => ckIsChecked.IsChecked.Value; }
        public bool IsApproved { get => ckIsApproved.IsChecked.Value; }
        public bool IsFinished { get => ckIsFinished.IsChecked.Value; }
        public bool IsFeeChecked { get => ckIsFeeChecked.IsChecked.Value; }
        public bool IsMarkedOk { get => ckIsMarkedOk.IsChecked.Value; }
        public bool IsDoneOk { get => ckIsDoneOk.IsChecked.Value; }
        public bool IsPayed { get => ckIsPayed.IsChecked.Value; }
        public bool CkIsReadOnly { get => ckIsReadOnly.IsChecked.Value; }

        public StatusCombox()
        {
            ComboBoxItem item = new ComboBoxItem();
            item.Content=ckOrdIsActive;
            ckOrdIsActive.Content = Properties.Resources.OrdIsActive;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content=ckOrdIfExtraHours;
            ckOrdIfExtraHours.Content = Properties.Resources.OrdIfExtraHours;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content = ckIsChecked;
            ckIsChecked.Content = Properties.Resources.IsChecked;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content = ckIsApproved;
            ckIsApproved.Content = Properties.Resources.IsApproved;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content = ckIsFinished;
            ckIsFinished.Content = Properties.Resources.IsFinished;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content = ckIsFeeChecked;
            ckIsFeeChecked.Content = Properties.Resources.IsFeeChecked;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content = ckIsMarkedOk;
            ckIsMarkedOk.Content = Properties.Resources.IsMarkedOk;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content = ckIsDoneOk;
            ckIsDoneOk.Content = Properties.Resources.IsDoneOk;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content = ckIsPayed;
            ckIsPayed.Content = Properties.Resources.IsPayed;
            Items.Add(item);

            item = new ComboBoxItem();
            item.Content = ckIsReadOnly;
            ckIsReadOnly.Content = Properties.Resources.IsReadOnly;
            Items.Add(item);

            ckOrdIsActive.Checked += CkOrdIsActive_Checked;
            ckOrdIsActive.Unchecked += CkOrdIsActive_Checked;

            ckOrdIfExtraHours.Checked += CkOrdIsActive_Checked;
            ckOrdIfExtraHours.Unchecked += CkOrdIsActive_Checked;

            ckIsChecked.Checked += CkOrdIsActive_Checked;
            ckIsChecked.Unchecked += CkOrdIsActive_Checked;

            ckIsApproved.Checked += CkOrdIsActive_Checked;
            ckIsApproved.Unchecked += CkOrdIsActive_Checked;

            ckIsFinished.Checked += CkOrdIsActive_Checked;
            ckIsFinished.Unchecked += CkOrdIsActive_Checked;

            ckIsFeeChecked.Checked += CkOrdIsActive_Checked;
            ckIsFeeChecked.Unchecked += CkOrdIsActive_Checked;

            ckIsMarkedOk.Checked += CkOrdIsActive_Checked;
            ckIsMarkedOk.Unchecked += CkOrdIsActive_Checked;

            ckIsDoneOk.Checked += CkOrdIsActive_Checked;
            ckIsDoneOk.Unchecked += CkOrdIsActive_Checked;

            ckIsPayed.Checked += CkOrdIsActive_Checked;
            ckIsPayed.Unchecked += CkOrdIsActive_Checked;

            ckIsReadOnly.Checked += CkOrdIsActive_Checked;
            ckIsReadOnly.Unchecked += CkOrdIsActive_Checked;


        }

        private void CkOrdIsActive_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            if(sender is CheckBox ck)
            {
                if (ck.IsChecked.Value)
                {
                    if (Text.Contains(ck.Content.ToString()))
                        return;
                    Text += ck.Content.ToString() + ",";
                }
                else
                {
                    if (!Text.Contains(ck.Content.ToString()))
                        return;
                    Text = Text.Replace(ck.Content.ToString() + ",", "");
                }
            }
        }
    }
}
