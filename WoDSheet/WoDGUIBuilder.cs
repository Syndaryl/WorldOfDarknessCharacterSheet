using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Games.RPG.WoDCharacterData;
using System.Drawing;
using System.Drawing.Imaging;

namespace Games.RPG.WoDSheet
{
    class WoDGUIBuilder
    {
        internal static FlowLayoutPanel Build(WoDCharacter Character, FlowLayoutPanel root)
        {
            if (root == null)
                root = new FlowLayoutPanel();
            else
                root.Controls.Clear();

            root.SuspendLayout();
            root.FlowDirection = FlowDirection.TopDown;

            AddBanner(Character, root);

            foreach (TraitGroup item in Character.TraitGroups)
            {
                FlowLayoutPanel p = MakePrimarySection(item, root);
            }

            root.ResumeLayout();
            return root;
        }

        internal static void Build(WoDCharacter Character, Form displayForm)
        {
            displayForm.SuspendLayout();
            
            AddName(Character, displayForm);

            displayForm.ResumeLayout();
            displayForm.Refresh();
        }

        private static FlowLayoutPanel MakePrimarySection(TraitGroup group, Panel parent)
        {
            FlowLayoutPanel ChildItems;
            ChildItems = NewFlowPanel(parent, parent.Width);
            ChildItems.SuspendLayout();

            AddLabel(group.Name, ChildItems, true);
            if (group.ChildGroups.Count > 0)
            {
                FlowLayoutPanel ChildHolder = MakeChildPanels(group, ChildItems);
                ChildHolder.Width = ChildHolder.PreferredSize.Width;
                ChildHolder.Height = ChildHolder.PreferredSize.Height;
            }
            else
            {
                MakeChildTraits(group, ChildItems);
            }
            ChildItems.Height = ChildItems.PreferredSize.Height;

            ChildItems.ResumeLayout();
            return ChildItems;
        }
        private static FlowLayoutPanel MakeSection(TraitGroup group, Panel parent)
        {
            //FlowLayoutPanel ChildItems = NewFlowPanel(parent, (int) (parent.Width/group.ChildGroups.Count));

            FlowLayoutPanel ChildItems;
            ChildItems = NewFlowPanel(parent, group.ChildGroups.Count > 0?(int)(parent.Width / group.ChildGroups.Count):parent.Width);
            ChildItems.SuspendLayout();

            AddLabel(group.Name, ChildItems, true);

            if ( group.ChildGroups.Count > 0)
            {
                MakeChildPanels(group, ChildItems);
            }
            else
            {
                MakeChildTraits(group, ChildItems);
            }
            ChildItems.Height = ChildItems.PreferredSize.Height;

            ChildItems.ResumeLayout();
            return ChildItems;
        }

        private static FlowLayoutPanel NewFlowPanel(Panel location, int width)
        {
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.SuspendLayout();
            location.Controls.Add(flow);
            flow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //parent.Width = (int)(parent.Size.Width - 10);
            flow.Width = width - 10;
            flow.Padding = new System.Windows.Forms.Padding(10);
            flow.AutoScroll = true;
            //parent.AutoSize = true;
            flow.AutoScroll = true;
            flow.WrapContents = false;
            flow.ResumeLayout();
            return flow;
        }

        private static void MakeChildTraits(TraitGroup group, FlowLayoutPanel location)
        {
            location.FlowDirection = FlowDirection.TopDown;
            foreach (Trait item in group.Children)
            {
                //if (TestType < NameTextRating>(item) > -1)
                //{
                //    try
                //    {
                //        AddTextSlider(parent, item);
                //    }
                //    catch (Exception WoDSliderCreationException)
                //    {
                //        MessageBox.Show(WoDSliderCreationException.ToString());
                //    }

                //}
                //else 
                    if (TestType<INamedTrait>(item) > -1)
                    AddLabel(((INamedTrait)item).Name, location, false);
            }
        }

        private static void AddTextSlider(FlowLayoutPanel location, Trait item)
        {
            NameTextRating itemCasted = (NameTextRating)item;
            WodSlider slider = new WodSlider(LabelText: itemCasted.Name, SpecialtyText: itemCasted.Text, Rating: itemCasted.Rating);
            location.Controls.Add(slider);
            int width = (int)(location.Size.Width - 10);
            slider.Size = new Size(width, slider.PreferredHeight);
        }

        private static FlowLayoutPanel MakeChildPanels(TraitGroup group, FlowLayoutPanel parent)
        {
            parent.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanel ChildItems;
            ChildItems = NewFlowPanel(parent, group.ChildGroups.Count > 0 ? (int)(parent.Width / group.ChildGroups.Count) : parent.Width);
            ChildItems.SuspendLayout();

            FlowDirection direction;
            Enum.TryParse<FlowDirection>(group.Orientation, true, out direction);
            ChildItems.FlowDirection = direction;

            foreach (TraitGroup item in group.ChildGroups)
            {
                FlowLayoutPanel p = MakeSection(item, ChildItems);
            }

            ChildItems.ResumeLayout();

            return ChildItems;
        }

        private static void AddLabel(string text, Panel location, bool bold=false, int width = 0)
        {
            if (text == null || text == string.Empty || text.Equals(""))
                return; // short circuit.
            try
            {
                Label formLabel = new Label();
                //formLabel.AutoSize = true;
                location.Controls.Add(formLabel);
                formLabel.Text = text;
                formLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                formLabel.Tag = 0;
                formLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                formLabel.Padding = new Padding(10);
                //Font newfont = (Font) parent.Font.Clone();
                //newfont.Bold = bold;
                //formLabel.Font = (Font)parent.Font.Clone();
                formLabel.Font = new Font(location.Font.FontFamily, location.Font.Size, bold? FontStyle.Bold:FontStyle.Regular);
                if (width == 0)
                    width = (int)(location.Size.Width - 10);
                formLabel.Size = new Size(width, formLabel.PreferredHeight);
                //formLabel.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            }
            catch (Exception LabelCreationException)
            {
                MessageBox.Show(LabelCreationException.ToString());
            }
        }

        private static void AddLabel(string text, Panel location, int width = 0)
        {
            AddLabel(text, location, false, width);
        }

        private static void AddName(WoDCharacter Character, Form displayForm)
        {
            try
            {
                Label formLabel = new Label();
                formLabel.Text = Character.Name;
                formLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                formLabel.Tag = 0;
                formLabel.Location = new Point(50, 50); 
                formLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                formLabel.Size = new Size(formLabel.PreferredWidth, formLabel.PreferredHeight);
                formLabel.AutoSize = true;

                displayForm.Controls.Add(formLabel);
            }
            catch (Exception LabelCreationException)
            {

            }
        }

        private static void AddName(WoDCharacter Character, FlowLayoutPanel result)
        {
            try
            {
                AddLabel(Character.Name, result, true);
            }
            catch (Exception LabelCreationException)
            {

            }
        }

        private static void AddBanner(WoDCharacter Character, FlowLayoutPanel result)
        {
            try
            {
                AddName(Character, result);
                Bitmap BannerGraphic = new Bitmap(Character.Graphic);
                PictureBox Banner = new PictureBox();

                result.Controls.Add(Banner);
                Banner.Image = BannerGraphic;
                Banner.Tag = 1;
                int newWidth = (int)(result.Size.Width - 10);
                //int newHeight = (int)(((double)newWidth / (double)Banner.PreferredSize.Width) * (double)Banner.PreferredSize.Height);
                Banner.Size = new Size(newWidth, 150);
                Banner.AccessibleName = Character.Name;
                Banner.SizeMode = PictureBoxSizeMode.Zoom;
                //Banner.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                //Banner.Dock = DockStyle.Fill;
                Banner.BorderStyle = BorderStyle.Fixed3D;
            }
            catch (Exception ImageCreationException)
            {
                AddName(Character, result);
            }
        }

        public static int TestType<T>(object obj) where T : class
        {
            T foo = obj as T; // This is how to test for if it is an object or fulfils a template
            if (foo != null)      // conveniently, it also does a null safety check!
                return foo.GetHashCode();
            return -1;
        }
    }
}
