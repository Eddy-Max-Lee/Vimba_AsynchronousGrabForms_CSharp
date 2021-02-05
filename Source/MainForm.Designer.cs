/*=============================================================================
  Copyright (C) 2012 Allied Vision Technologies.  All Rights Reserved.

  Redistribution of this file, in original or modified form, without
  prior written consent of Allied Vision Technologies is prohibited.

-------------------------------------------------------------------------------

  File:        MainForm.Designer.cs

  Description: Forms class for the GUI of the AsynchronousGrab example of
               VimbaNET.

-------------------------------------------------------------------------------

  THIS SOFTWARE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR IMPLIED
  WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF TITLE,
  NON-INFRINGEMENT, MERCHANTABILITY AND FITNESS FOR A PARTICULAR  PURPOSE ARE
  DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT,
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED
  AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR
  TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
  OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

=============================================================================*/

namespace AsynchronousGrab
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_CameraListTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_maxR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_minR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_p2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_p1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.m_AcquireButton = new System.Windows.Forms.Button();
            this.m_SoftwareTriggerTable = new System.Windows.Forms.TableLayoutPanel();
            this.m_SoftwareTriggerCheckbox = new System.Windows.Forms.CheckBox();
            this.m_SoftwareTriggerButton = new System.Windows.Forms.Button();
            this.tb_lens = new System.Windows.Forms.TextBox();
            this.m_CameraList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_LogList = new System.Windows.Forms.ListBox();
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.m_LogTable = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_expp = new System.Windows.Forms.TextBox();
            this.btn_modifyCross = new System.Windows.Forms.Button();
            this.tb_crossY = new System.Windows.Forms.TextBox();
            this.tb_crossX = new System.Windows.Forms.TextBox();
            this.tb_exp = new System.Windows.Forms.TrackBar();
            this.cb_cross = new System.Windows.Forms.CheckBox();
            this.rtb_result = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_stamp = new System.Windows.Forms.Button();
            this.pb_sub = new System.Windows.Forms.PictureBox();
            this.lb_result = new System.Windows.Forms.Label();
            this.lb_center1 = new System.Windows.Forms.Label();
            this.lb_center0 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_center1 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.m_DisplayPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.m_CameraListTable.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.m_SoftwareTriggerTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.m_LogTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.m_DisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_CameraListTable
            // 
            this.m_CameraListTable.ColumnCount = 1;
            this.m_CameraListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_CameraListTable.Controls.Add(this.tableLayoutPanel5, 0, 8);
            this.m_CameraListTable.Controls.Add(this.tableLayoutPanel4, 0, 7);
            this.m_CameraListTable.Controls.Add(this.tableLayoutPanel3, 0, 6);
            this.m_CameraListTable.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.m_CameraListTable.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.m_CameraListTable.Controls.Add(this.m_AcquireButton, 0, 2);
            this.m_CameraListTable.Controls.Add(this.m_SoftwareTriggerTable, 0, 3);
            this.m_CameraListTable.Controls.Add(this.m_CameraList, 0, 1);
            this.m_CameraListTable.Controls.Add(this.label1, 0, 0);
            this.m_CameraListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_CameraListTable.Location = new System.Drawing.Point(0, 0);
            this.m_CameraListTable.Name = "m_CameraListTable";
            this.m_CameraListTable.RowCount = 10;
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.735847F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.35849F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.103773F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.103773F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.106259F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.919811F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.919811F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.919811F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.91981F));
            this.m_CameraListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.912621F));
            this.m_CameraListTable.Size = new System.Drawing.Size(389, 518);
            this.m_CameraListTable.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09402F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.23932F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Controls.Add(this.tb_maxR, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.trackBar4, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 470);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(383, 24);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // tb_maxR
            // 
            this.tb_maxR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_maxR.Location = new System.Drawing.Point(321, 3);
            this.tb_maxR.Name = "tb_maxR";
            this.tb_maxR.Size = new System.Drawing.Size(59, 25);
            this.tb_maxR.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "最大半徑";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar4
            // 
            this.trackBar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar4.Location = new System.Drawing.Point(68, 3);
            this.trackBar4.Maximum = 1000;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(247, 18);
            this.trackBar4.TabIndex = 2;
            this.trackBar4.Value = 150;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09402F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.23932F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Controls.Add(this.tb_minR, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.trackBar3, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 440);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(383, 24);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // tb_minR
            // 
            this.tb_minR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_minR.Location = new System.Drawing.Point(321, 3);
            this.tb_minR.Name = "tb_minR";
            this.tb_minR.Size = new System.Drawing.Size(59, 25);
            this.tb_minR.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "最小半徑";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar3
            // 
            this.trackBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar3.Location = new System.Drawing.Point(68, 3);
            this.trackBar3.Maximum = 1000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(247, 18);
            this.trackBar3.TabIndex = 2;
            this.trackBar3.Value = 20;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09402F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.23932F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.tb_p2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.trackBar2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 410);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(383, 24);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // tb_p2
            // 
            this.tb_p2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_p2.Location = new System.Drawing.Point(321, 3);
            this.tb_p2.Name = "tb_p2";
            this.tb_p2.Size = new System.Drawing.Size(59, 25);
            this.tb_p2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "中心閥值";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar2.Location = new System.Drawing.Point(68, 3);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Minimum = 10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(247, 18);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Value = 30;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.81379F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.15343F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.03279F));
            this.tableLayoutPanel2.Controls.Add(this.tb_p1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.trackBar1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 380);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 24);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tb_p1
            // 
            this.tb_p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_p1.Location = new System.Drawing.Point(316, 3);
            this.tb_p1.Name = "tb_p1";
            this.tb_p1.Size = new System.Drawing.Size(64, 25);
            this.tb_p1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "邊緣閥值";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(67, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(243, 18);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Load, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 344);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 29);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(107, 3);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(95, 23);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "Load Image";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_AcquireButton
            // 
            this.m_AcquireButton.AutoSize = true;
            this.m_AcquireButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_AcquireButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_AcquireButton.Enabled = false;
            this.m_AcquireButton.Location = new System.Drawing.Point(5, 272);
            this.m_AcquireButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 0);
            this.m_AcquireButton.Name = "m_AcquireButton";
            this.m_AcquireButton.Size = new System.Drawing.Size(379, 33);
            this.m_AcquireButton.TabIndex = 3;
            this.m_AcquireButton.Text = "Start image acquisition";
            this.m_AcquireButton.UseVisualStyleBackColor = true;
            this.m_AcquireButton.Click += new System.EventHandler(this.AcquireButton_Click);
            // 
            // m_SoftwareTriggerTable
            // 
            this.m_SoftwareTriggerTable.AutoSize = true;
            this.m_SoftwareTriggerTable.ColumnCount = 3;
            this.m_SoftwareTriggerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.58333F));
            this.m_SoftwareTriggerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.08333F));
            this.m_SoftwareTriggerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.m_SoftwareTriggerTable.Controls.Add(this.m_SoftwareTriggerCheckbox, 0, 0);
            this.m_SoftwareTriggerTable.Controls.Add(this.m_SoftwareTriggerButton, 1, 0);
            this.m_SoftwareTriggerTable.Controls.Add(this.tb_lens, 2, 0);
            this.m_SoftwareTriggerTable.Location = new System.Drawing.Point(3, 308);
            this.m_SoftwareTriggerTable.Name = "m_SoftwareTriggerTable";
            this.m_SoftwareTriggerTable.RowCount = 1;
            this.m_SoftwareTriggerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_SoftwareTriggerTable.Size = new System.Drawing.Size(371, 30);
            this.m_SoftwareTriggerTable.TabIndex = 4;
            // 
            // m_SoftwareTriggerCheckbox
            // 
            this.m_SoftwareTriggerCheckbox.AutoSize = true;
            this.m_SoftwareTriggerCheckbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_SoftwareTriggerCheckbox.Enabled = false;
            this.m_SoftwareTriggerCheckbox.Location = new System.Drawing.Point(33, 3);
            this.m_SoftwareTriggerCheckbox.Name = "m_SoftwareTriggerCheckbox";
            this.m_SoftwareTriggerCheckbox.Size = new System.Drawing.Size(18, 24);
            this.m_SoftwareTriggerCheckbox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.m_SoftwareTriggerCheckbox, "When checked, the acquisition of a single frame gets triggered by a click on the " +
        "button.");
            this.m_SoftwareTriggerCheckbox.UseVisualStyleBackColor = true;
            this.m_SoftwareTriggerCheckbox.CheckedChanged += new System.EventHandler(this.SoftwareTriggerCheckbox_CheckedChanged);
            // 
            // m_SoftwareTriggerButton
            // 
            this.m_SoftwareTriggerButton.AutoSize = true;
            this.m_SoftwareTriggerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_SoftwareTriggerButton.Enabled = false;
            this.m_SoftwareTriggerButton.Location = new System.Drawing.Point(57, 3);
            this.m_SoftwareTriggerButton.Name = "m_SoftwareTriggerButton";
            this.m_SoftwareTriggerButton.Size = new System.Drawing.Size(187, 24);
            this.m_SoftwareTriggerButton.TabIndex = 1;
            this.m_SoftwareTriggerButton.Text = "Software Trigger";
            this.m_SoftwareTriggerButton.UseVisualStyleBackColor = true;
            this.m_SoftwareTriggerButton.Click += new System.EventHandler(this.SoftwareTriggerButton_Click);
            // 
            // tb_lens
            // 
            this.tb_lens.Location = new System.Drawing.Point(250, 3);
            this.tb_lens.Name = "tb_lens";
            this.tb_lens.Size = new System.Drawing.Size(115, 25);
            this.tb_lens.TabIndex = 2;
            this.tb_lens.Text = "Name";
            this.tb_lens.TextChanged += new System.EventHandler(this.tb_lens_TextChanged);
            this.tb_lens.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_lens_MouseDown);
            // 
            // m_CameraList
            // 
            this.m_CameraList.AllowDrop = true;
            this.m_CameraList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_CameraList.FormattingEnabled = true;
            this.m_CameraList.IntegralHeight = false;
            this.m_CameraList.ItemHeight = 15;
            this.m_CameraList.Location = new System.Drawing.Point(0, 27);
            this.m_CameraList.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.m_CameraList.Name = "m_CameraList";
            this.m_CameraList.Size = new System.Drawing.Size(389, 242);
            this.m_CameraList.TabIndex = 1;
            this.m_CameraList.Click += new System.EventHandler(this.m_CameraList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cameras:";
            // 
            // m_LogList
            // 
            this.m_LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_LogList.FormattingEnabled = true;
            this.m_LogList.IntegralHeight = false;
            this.m_LogList.ItemHeight = 15;
            this.m_LogList.Location = new System.Drawing.Point(0, 15);
            this.m_LogList.Margin = new System.Windows.Forms.Padding(0);
            this.m_LogList.Name = "m_LogList";
            this.m_LogList.Size = new System.Drawing.Size(1426, 124);
            this.m_LogList.TabIndex = 1;
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(676, 514);
            this.m_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBox.TabIndex = 2;
            this.m_PictureBox.TabStop = false;
            this.m_PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.m_PictureBox.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // m_LogTable
            // 
            this.m_LogTable.ColumnCount = 1;
            this.m_LogTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_LogTable.Controls.Add(this.m_LogList, 0, 1);
            this.m_LogTable.Controls.Add(this.label2, 0, 0);
            this.m_LogTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_LogTable.Location = new System.Drawing.Point(0, 0);
            this.m_LogTable.Name = "m_LogTable";
            this.m_LogTable.RowCount = 2;
            this.m_LogTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.m_LogTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.m_LogTable.Size = new System.Drawing.Size(1426, 139);
            this.m_LogTable.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log messages:";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1420, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Programming example to demonstrate how to acquire images asynchronously (grab) wi" +
    "th VimbaNET.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 664);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1426, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.tb_expp);
            this.splitContainer1.Panel1.Controls.Add(this.btn_modifyCross);
            this.splitContainer1.Panel1.Controls.Add(this.tb_crossY);
            this.splitContainer1.Panel1.Controls.Add(this.tb_crossX);
            this.splitContainer1.Panel1.Controls.Add(this.tb_exp);
            this.splitContainer1.Panel1.Controls.Add(this.cb_cross);
            this.splitContainer1.Panel1.Controls.Add(this.rtb_result);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_stamp);
            this.splitContainer1.Panel1.Controls.Add(this.pb_sub);
            this.splitContainer1.Panel1.Controls.Add(this.lb_result);
            this.splitContainer1.Panel1.Controls.Add(this.lb_center1);
            this.splitContainer1.Panel1.Controls.Add(this.lb_center0);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btn_center1);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_LogTable);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(1426, 661);
            this.splitContainer1.SplitterDistance = 518;
            this.splitContainer1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(1095, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "標記";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Purple;
            this.button5.Location = new System.Drawing.Point(1228, 484);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 30);
            this.button5.TabIndex = 19;
            this.button5.Text = "設為預設";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(1116, 484);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 30);
            this.button4.TabIndex = 18;
            this.button4.Text = "載入預設";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_expp
            // 
            this.tb_expp.Location = new System.Drawing.Point(1317, 397);
            this.tb_expp.Name = "tb_expp";
            this.tb_expp.Size = new System.Drawing.Size(97, 25);
            this.tb_expp.TabIndex = 17;
            this.tb_expp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_expp_KeyDown);
            // 
            // btn_modifyCross
            // 
            this.btn_modifyCross.ForeColor = System.Drawing.Color.Red;
            this.btn_modifyCross.Location = new System.Drawing.Point(1334, 448);
            this.btn_modifyCross.Name = "btn_modifyCross";
            this.btn_modifyCross.Size = new System.Drawing.Size(54, 30);
            this.btn_modifyCross.TabIndex = 16;
            this.btn_modifyCross.Text = "更改";
            this.btn_modifyCross.UseVisualStyleBackColor = true;
            this.btn_modifyCross.Click += new System.EventHandler(this.btn_modifyCross_Click);
            // 
            // tb_crossY
            // 
            this.tb_crossY.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_crossY.ForeColor = System.Drawing.Color.Red;
            this.tb_crossY.Location = new System.Drawing.Point(1257, 450);
            this.tb_crossY.Name = "tb_crossY";
            this.tb_crossY.Size = new System.Drawing.Size(70, 28);
            this.tb_crossY.TabIndex = 15;
            this.tb_crossY.Text = "512";
            // 
            // tb_crossX
            // 
            this.tb_crossX.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_crossX.ForeColor = System.Drawing.Color.Red;
            this.tb_crossX.Location = new System.Drawing.Point(1181, 450);
            this.tb_crossX.Name = "tb_crossX";
            this.tb_crossX.Size = new System.Drawing.Size(70, 28);
            this.tb_crossX.TabIndex = 14;
            this.tb_crossX.Text = "640";
            // 
            // tb_exp
            // 
            this.tb_exp.Location = new System.Drawing.Point(1100, 397);
            this.tb_exp.Maximum = 60000;
            this.tb_exp.Minimum = 20000;
            this.tb_exp.Name = "tb_exp";
            this.tb_exp.Size = new System.Drawing.Size(227, 56);
            this.tb_exp.TabIndex = 13;
            this.tb_exp.Value = 30000;
            this.tb_exp.Scroll += new System.EventHandler(this.trackBar5_Scroll_1);
            // 
            // cb_cross
            // 
            this.cb_cross.AutoSize = true;
            this.cb_cross.Checked = true;
            this.cb_cross.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_cross.Enabled = false;
            this.cb_cross.ForeColor = System.Drawing.Color.Red;
            this.cb_cross.Location = new System.Drawing.Point(1095, 454);
            this.cb_cross.Name = "cb_cross";
            this.cb_cross.Size = new System.Drawing.Size(89, 19);
            this.cb_cross.TabIndex = 12;
            this.cb_cross.Text = "十字座標";
            this.cb_cross.UseVisualStyleBackColor = true;
            this.cb_cross.CheckedChanged += new System.EventHandler(this.cb_cross_CheckedChanged);
            // 
            // rtb_result
            // 
            this.rtb_result.Location = new System.Drawing.Point(1181, 115);
            this.rtb_result.Name = "rtb_result";
            this.rtb_result.Size = new System.Drawing.Size(141, 96);
            this.rtb_result.TabIndex = 11;
            this.rtb_result.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1204, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 49);
            this.button3.TabIndex = 10;
            this.button3.Text = "multiple_stamp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_stamp
            // 
            this.btn_stamp.Location = new System.Drawing.Point(1095, 252);
            this.btn_stamp.Name = "btn_stamp";
            this.btn_stamp.Size = new System.Drawing.Size(103, 53);
            this.btn_stamp.TabIndex = 9;
            this.btn_stamp.Text = "蓋上戳章";
            this.btn_stamp.UseVisualStyleBackColor = true;
            this.btn_stamp.Click += new System.EventHandler(this.btn_stamp_Click);
            // 
            // pb_sub
            // 
            this.pb_sub.Location = new System.Drawing.Point(1097, 308);
            this.pb_sub.Margin = new System.Windows.Forms.Padding(0);
            this.pb_sub.Name = "pb_sub";
            this.pb_sub.Size = new System.Drawing.Size(278, 86);
            this.pb_sub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_sub.TabIndex = 8;
            this.pb_sub.TabStop = false;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_result.Location = new System.Drawing.Point(1091, 124);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(0, 20);
            this.lb_result.TabIndex = 7;
            // 
            // lb_center1
            // 
            this.lb_center1.AutoSize = true;
            this.lb_center1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_center1.Location = new System.Drawing.Point(1215, 78);
            this.lb_center1.Name = "lb_center1";
            this.lb_center1.Size = new System.Drawing.Size(0, 20);
            this.lb_center1.TabIndex = 6;
            // 
            // lb_center0
            // 
            this.lb_center0.AutoSize = true;
            this.lb_center0.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_center0.Location = new System.Drawing.Point(1215, 33);
            this.lb_center0.Name = "lb_center0";
            this.lb_center0.Size = new System.Drawing.Size(0, 20);
            this.lb_center0.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1095, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "圓心座標2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_center1
            // 
            this.btn_center1.Location = new System.Drawing.Point(1095, 9);
            this.btn_center1.Name = "btn_center1";
            this.btn_center1.Size = new System.Drawing.Size(103, 47);
            this.btn_center1.TabIndex = 3;
            this.btn_center1.Text = "圓心座標1";
            this.btn_center1.UseVisualStyleBackColor = true;
            this.btn_center1.Click += new System.EventHandler(this.btn_center1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.m_CameraListTable);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.m_DisplayPanel);
            this.splitContainer2.Panel2MinSize = 100;
            this.splitContainer2.Size = new System.Drawing.Size(1073, 518);
            this.splitContainer2.SplitterDistance = 389;
            this.splitContainer2.TabIndex = 0;
            // 
            // m_DisplayPanel
            // 
            this.m_DisplayPanel.AutoScroll = true;
            this.m_DisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_DisplayPanel.Controls.Add(this.m_PictureBox);
            this.m_DisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_DisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.m_DisplayPanel.Name = "m_DisplayPanel";
            this.m_DisplayPanel.Size = new System.Drawing.Size(680, 518);
            this.m_DisplayPanel.TabIndex = 3;
            this.m_DisplayPanel.DoubleClick += new System.EventHandler(this.DisplayPanel_DoubleClick);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1432, 713);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "VimbaNET Asynchronous Grab Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.m_CameraListTable.ResumeLayout(false);
            this.m_CameraListTable.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.m_SoftwareTriggerTable.ResumeLayout(false);
            this.m_SoftwareTriggerTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.m_LogTable.ResumeLayout(false);
            this.m_LogTable.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sub)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.m_DisplayPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel m_CameraListTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox m_CameraList;
        private System.Windows.Forms.ListBox m_LogList;
        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.TableLayoutPanel m_LogTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel m_DisplayPanel;
        private System.Windows.Forms.Button m_AcquireButton;
        private System.Windows.Forms.TableLayoutPanel m_SoftwareTriggerTable;
        private System.Windows.Forms.CheckBox m_SoftwareTriggerCheckbox;
        private System.Windows.Forms.Button m_SoftwareTriggerButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_p1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tb_p2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tb_minR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox tb_maxR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TextBox tb_lens;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_center1;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Label lb_center1;
        private System.Windows.Forms.Label lb_center0;
        private System.Windows.Forms.PictureBox pb_sub;
        private System.Windows.Forms.Button btn_stamp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox rtb_result;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cb_cross;
        private System.Windows.Forms.TrackBar tb_exp;
        private System.Windows.Forms.Button btn_modifyCross;
        private System.Windows.Forms.TextBox tb_crossY;
        private System.Windows.Forms.TextBox tb_crossX;
        private System.Windows.Forms.TextBox tb_expp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

