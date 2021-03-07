using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppinglist
{
    
    public partial class Form1 : Form
    {
        public List<TextBox> TextBoxList = new List<TextBox>();
        public List<CheckBox> CheckboxList = new List<CheckBox>();
        public List<Button> ButtonList = new List<Button>();
        int number = 0;
        public Form1()
        {
         InitializeComponent();
            
        }

        private void But_Click(object sender, EventArgs e)
        {
           
            TextBox tb = new TextBox();
            string Tpolozky = "Text" + number;
            tb.Name = Tpolozky;

            tb.Left = 20;
            tb.Top = But.Top + 0;
            tb.Width = 300;
            TextBoxList.Add(tb);
            Controls.Add(tb);

            CheckBox cb = new CheckBox();
            string CBcpolozky = "CheckBox" + number;
            cb.Name = CBcpolozky;
            CheckboxList.Add(cb);
            cb.Left = 340;
            cb.Width = 20;
            cb.Top = But.Top + 0;
            Controls.Add(cb);

            Button bl = new Button();
           int Bcpolozky = number;
            bl.Name = Convert.ToString(Bcpolozky);
            ButtonList.Add(bl);
            bl.Width = 50;
            bl.Left = 375;
            bl.Text = "Smazat";
            bl.Top = But.Top + 0;
            Controls.Add(bl);
            bl.Click += new EventHandler (this.Bcpolozky_Click);
            But.Top += 30;
            number++;
        }
        void Bcpolozky_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int bCount = 0; bCount < ButtonList.Count; bCount++)
            {
                if (btn == ButtonList[bCount])
                {
                    this.Controls.Remove(TextBoxList[bCount]);
                    TextBoxList.RemoveAt(bCount);
                    this.Controls.Remove(CheckboxList[bCount]);
                    CheckboxList.RemoveAt(bCount);
                    this.Controls.Remove(ButtonList[bCount]);
                    ButtonList.RemoveAt(bCount);
                    number--;
                    try { 
                    for (int i = bCount; i < ButtonList.Count; i++)
                        {
                        TextBoxList[i].Top -= 30;
                        CheckboxList[i].Top -= 30;
                        ButtonList[i].Top -= 30;
                        }
                        But.Top -= 30;
                    }
                    catch
                    {
                        
                    }
                }
            }
        }
    }
}
