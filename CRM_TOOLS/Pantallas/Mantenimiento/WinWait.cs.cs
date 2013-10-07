using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace CRM_TOOLS.Pantallas.Mantenimiento
{
    public partial class WinWait_cs : Telerik.WinControls.UI.RadForm
    {

        bool flag;
        public WinWait_cs()
        {
          
            InitializeComponent();
            flag = false; 
        
            
        }
        public void UpdateProgress(int progress)
        {
            if (ProgressBar1.InvokeRequired)
                ProgressBar1.BeginInvoke(new Action(() => ProgressBar1.Value = progress));
            else
                ProgressBar1.Value = progress;

        }

        public void SetIndeterminate(bool isIndeterminate)
        {
            if (ProgressBar1.InvokeRequired)
            {
                ProgressBar1.BeginInvoke(new Action(() =>
                {
                    if (isIndeterminate)
                        ProgressBar1.Style = ProgressBarStyle.Marquee;
                    else
                        ProgressBar1.Style = ProgressBarStyle.Blocks;
                }
                ));
            }
            else
            {
                if (isIndeterminate)
                    ProgressBar1.Style = ProgressBarStyle.Marquee;
                else
                    ProgressBar1.Style = ProgressBarStyle.Blocks;
            }
        }
        private void WinWait_cs_Load(object sender, EventArgs e)
        {
           // if (flag)
            //{
               // this.radWaitingBar1.StartWaiting();
            //}
            //flag = true;
        }

    }
}
