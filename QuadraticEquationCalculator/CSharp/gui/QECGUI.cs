using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;
using TextBox = System.Windows.Forms.TextBox;
using Label = System.Windows.Forms.Label;
using Button = System.Windows.Forms.Button;
using HorizontalAligment =System.Windows.Forms.HorizontalAlignment;
using AutoScaleMode = System.Windows.Forms.AutoScaleMode;
using QuadraticEquation = quadraticEquation.QuadraticEquation;
namespace gui
{
    public class QECGUI : Form
    {
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDelta;
        private Label lblResult;
        private Button btnOk;

        public QECGUI()
        {
            this.txtA = new TextBox();
            this.txtB = new TextBox();
            this.txtC = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.lblDelta = new Label();
            this.lblResult = new Label();
            this.btnOk = new Button();
            this.SuspendLayout();
            
            // txtA
            this.txtA.Location = new Point(12, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(34, 20);
            this.txtA.TabIndex = 0;
            this.txtA.Text = "0";
            this.txtA.TextAlign = HorizontalAlignment.Right;
            
            // txtB
            this.txtB.Location = new Point(85, 12);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(34, 20);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "0";
            this.txtB.TextAlign = HorizontalAlignment.Right;
            
            // txtC
            this.txtC.Location = new Point(155, 12);
            this.txtC.Name = "txtC";
            this.txtC.Size = new Size(34, 20);
            this.txtC.TabIndex = 2;
            this.txtC.Text = "0";
            this.txtC.TextAlign = HorizontalAlignment.Right;
            
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x  +";
            
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new Point(125, 15);
            this.label2.Name = "label2";
            this.label2.Size = new Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x²  +";
            
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new Point(195, 15);
            this.label3.Name = "label3";
            this.label3.Size = new Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "=  0";

            // lblDelta
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new Point(12, 49);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new Size(17, 13);
            this.lblDelta.TabIndex = 6;
            this.lblDelta.Text = "Δ:";

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new Point(12, 77);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new Size(40, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result:";

            // btnOk
            this.btnOk.Location = new Point(235, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new Size(36, 20);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(298, 117);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "QECGUI";
            this.Text = "Quadratic Equation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try{
                double a = Convert.ToDouble(this.txtA.Text);
                double b = Convert.ToDouble(this.txtB.Text);
                double c = Convert.ToDouble(this.txtC.Text);
                QuadraticEquation qe = new QuadraticEquation(a, b, c);
                this.lblDelta.Text = qe.getSDelta();
                this.lblResult.Text = qe.getSResult();
            }catch (Exception ex){
                this.lblResult.Text = "Result : Inavalid value!";
            }
        }

    }
}
