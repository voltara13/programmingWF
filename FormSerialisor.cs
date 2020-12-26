using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace programmingWF
{
    public static class FormSerialisor
    {
        public static void Serialise(Control c, string XmlFileName)
        {
            var xmlSerialisedForm = new XmlTextWriter(XmlFileName, Encoding.Default);
            xmlSerialisedForm.Formatting = Formatting.Indented;
            xmlSerialisedForm.WriteStartDocument();
            xmlSerialisedForm.WriteStartElement("ChildForm");
            AddChildControls(xmlSerialisedForm, c);
            xmlSerialisedForm.WriteEndElement();
            xmlSerialisedForm.WriteEndDocument();
            xmlSerialisedForm.Flush();
            xmlSerialisedForm.Close();
        }

        private static void AddChildControls(XmlTextWriter xmlSerialisedForm, Control c)
        {
            foreach (Control childCtrl in c.Controls)
                if (!(childCtrl is Label))
                {
                    xmlSerialisedForm.WriteStartElement("Control");
                    xmlSerialisedForm.WriteAttributeString("Type", childCtrl.GetType().ToString());
                    xmlSerialisedForm.WriteAttributeString("Name", childCtrl.Name);
                    if (childCtrl is TextBox)
                    {
                        xmlSerialisedForm.WriteElementString("Text", ((TextBox) childCtrl).Text);
                    }
                    else if (childCtrl is ComboBox)
                    {
                        xmlSerialisedForm.WriteElementString("Text", ((ComboBox) childCtrl).Text);
                        xmlSerialisedForm.WriteElementString("SelectedIndex",
                            ((ComboBox) childCtrl).SelectedIndex.ToString());
                    }
                    else if (childCtrl is ListBox)
                    {
                        var lst = (ListBox) childCtrl;
                        if (lst.SelectedIndex == -1)
                            xmlSerialisedForm.WriteElementString("SelectedIndex", "-1");
                        else
                            for (var i = 0; i < lst.SelectedIndices.Count; i++)
                                xmlSerialisedForm.WriteElementString("SelectedIndex",
                                    lst.SelectedIndices[i].ToString());
                    }
                    else if (childCtrl is CheckBox)
                    {
                        xmlSerialisedForm.WriteElementString("Checked", ((CheckBox) childCtrl).Checked.ToString());
                    }
                    else if (childCtrl is ListView)
                    {

                    }
                    var visible = (bool) typeof(Control)
                        .GetMethod("GetState", BindingFlags.Instance | BindingFlags.NonPublic)
                        .Invoke(childCtrl, new object[] {2});
                    xmlSerialisedForm.WriteElementString("Visible", visible.ToString());
                    if (childCtrl.HasChildren)
                    {
                        if (childCtrl is SplitContainer)
                        {
                            AddChildControls(xmlSerialisedForm, ((SplitContainer) childCtrl).Panel1);
                            AddChildControls(xmlSerialisedForm, ((SplitContainer) childCtrl).Panel2);
                        }
                        else
                        {
                            AddChildControls(xmlSerialisedForm, childCtrl);
                        }
                    }
                    xmlSerialisedForm.WriteEndElement();
                }
        }

        public static void Deserialise(Control c, string XmlFileName)
        {
            if (File.Exists(XmlFileName))
            {
                var xmlSerialisedForm = new XmlDocument();
                xmlSerialisedForm.Load(XmlFileName);
                var topLevel = xmlSerialisedForm.ChildNodes[1];
                foreach (XmlNode n in topLevel.ChildNodes) SetControlProperties(c, n);
            }
        }

        private static void SetControlProperties(Control currentCtrl, XmlNode n)
        {
            var controlName = n.Attributes["Name"].Value;
            var controlType = n.Attributes["Type"].Value;
            var ctrl = currentCtrl.Controls.Find(controlName, true);
            if (ctrl.Length == 0) return;
            var ctrlToSet = GetImmediateChildControl(ctrl, currentCtrl);
            if (ctrlToSet != null)
            {
                if (ctrlToSet.GetType().ToString() == controlType)
                {
                    switch (controlType)
                    {
                        case "System.Windows.Forms.TextBox":
                            ((TextBox) ctrlToSet).Text = n["Text"].InnerText;
                            break;
                        case "System.Windows.Forms.ComboBox":
                            ((ComboBox) ctrlToSet).Text = n["Text"].InnerText;
                            ((ComboBox) ctrlToSet).SelectedIndex = Convert.ToInt32(n["SelectedIndex"].InnerText);
                            break;
                        case "System.Windows.Forms.ListBox":
                            var lst = (ListBox) ctrlToSet;
                            var xnlSelectedIndex = n.SelectNodes("SelectedIndex");
                            for (var i = 0; i < xnlSelectedIndex.Count; i++)
                                lst.SelectedIndex = Convert.ToInt32(xnlSelectedIndex[i].InnerText);
                            break;
                        case "System.Windows.Forms.CheckBox":
                            ((CheckBox) ctrlToSet).Checked = Convert.ToBoolean(n["Checked"].InnerText);
                            break;
                    }

                    ctrlToSet.Visible = Convert.ToBoolean(n["Visible"].InnerText);
                    if (n.HasChildNodes && ctrlToSet.HasChildren)
                    {
                        var xnlControls = n.SelectNodes("Control");
                        foreach (XmlNode n2 in xnlControls) SetControlProperties(ctrlToSet, n2);
                    }
                }
            }
        }

        private static Control GetImmediateChildControl(Control[] ctrl, Control currentCtrl)
        {
            Control c = null;
            for (var i = 0; i < ctrl.Length; i++)
                if (ctrl[i].Parent.Name == currentCtrl.Name ||
                    currentCtrl is SplitContainer && ctrl[i].Parent.Parent.Name == currentCtrl.Name)
                {
                    c = ctrl[i];
                    break;
                }

            return c;
        }
    }
}