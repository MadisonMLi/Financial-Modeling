namespace MC_CV
{
    partial class Monte
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
            this.btmGo = new System.Windows.Forms.Button();
            this.S_text = new System.Windows.Forms.TextBox();
            this.K_text = new System.Windows.Forms.TextBox();
            this.r_text = new System.Windows.Forms.TextBox();
            this.Sigma_text = new System.Windows.Forms.TextBox();
            this.T_text = new System.Windows.Forms.TextBox();
            this.N_text = new System.Windows.Forms.TextBox();
            this.M_text = new System.Windows.Forms.TextBox();
            this.btmCall = new System.Windows.Forms.RadioButton();
            this.btmPut = new System.Windows.Forms.RadioButton();
            this.lbS = new System.Windows.Forms.Label();
            this.lbK = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.lbSigma = new System.Windows.Forms.Label();
            this.lbT = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbSE = new System.Windows.Forms.Label();
            this.lbRho = new System.Windows.Forms.Label();
            this.lbTheta = new System.Windows.Forms.Label();
            this.lbVega = new System.Windows.Forms.Label();
            this.lbGa = new System.Windows.Forms.Label();
            this.lbDelta = new System.Windows.Forms.Label();
            this.lbP = new System.Windows.Forms.Label();
            this.SE_text = new System.Windows.Forms.TextBox();
            this.Rho_text = new System.Windows.Forms.TextBox();
            this.Theta_text = new System.Windows.Forms.TextBox();
            this.Vega_text = new System.Windows.Forms.TextBox();
            this.Gamma_text = new System.Windows.Forms.TextBox();
            this.Delta_text = new System.Windows.Forms.TextBox();
            this.Price_text = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Serror = new System.Windows.Forms.ErrorProvider(this.components);
            this.Kerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.Rerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.Verror = new System.Windows.Forms.ErrorProvider(this.components);
            this.Terror = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.Merror = new System.Windows.Forms.ErrorProvider(this.components);
            this.Outputs = new System.Windows.Forms.GroupBox();
            this.Timer = new System.Windows.Forms.Label();
            this.Timer_text = new System.Windows.Forms.TextBox();
            this.Inputs = new System.Windows.Forms.GroupBox();
            this.CallPut = new System.Windows.Forms.GroupBox();
            this.Choices = new System.Windows.Forms.GroupBox();
            this.multi = new System.Windows.Forms.CheckBox();
            this.CV = new System.Windows.Forms.CheckBox();
            this.Anthetic = new System.Windows.Forms.CheckBox();
            this.cpu = new System.Windows.Forms.Label();
            this.cpuCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Serror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Verror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Terror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merror)).BeginInit();
            this.Outputs.SuspendLayout();
            this.Inputs.SuspendLayout();
            this.CallPut.SuspendLayout();
            this.Choices.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmGo
            // 
            this.btmGo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btmGo.BackColor = System.Drawing.Color.Tan;
            this.btmGo.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGo.Location = new System.Drawing.Point(310, 371);
            this.btmGo.Name = "btmGo";
            this.btmGo.Size = new System.Drawing.Size(312, 74);
            this.btmGo.TabIndex = 0;
            this.btmGo.Text = "Calculate";
            this.btmGo.UseVisualStyleBackColor = false;
            this.btmGo.Click += new System.EventHandler(this.btmGo_Click);
            // 
            // S_text
            // 
            this.S_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_text.Location = new System.Drawing.Point(124, 40);
            this.S_text.Name = "S_text";
            this.S_text.Size = new System.Drawing.Size(133, 34);
            this.S_text.TabIndex = 1;
            this.S_text.Text = "50";
            this.S_text.TextChanged += new System.EventHandler(this.S_text_TextChanged);
            // 
            // K_text
            // 
            this.K_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K_text.Location = new System.Drawing.Point(124, 71);
            this.K_text.Name = "K_text";
            this.K_text.Size = new System.Drawing.Size(133, 34);
            this.K_text.TabIndex = 2;
            this.K_text.Text = "50";
            this.K_text.TextChanged += new System.EventHandler(this.K_text_TextChanged);
            // 
            // r_text
            // 
            this.r_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_text.Location = new System.Drawing.Point(124, 102);
            this.r_text.Name = "r_text";
            this.r_text.Size = new System.Drawing.Size(133, 34);
            this.r_text.TabIndex = 3;
            this.r_text.Text = "0.05";
            this.r_text.TextChanged += new System.EventHandler(this.r_text_TextChanged);
            // 
            // Sigma_text
            // 
            this.Sigma_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sigma_text.Location = new System.Drawing.Point(124, 133);
            this.Sigma_text.Name = "Sigma_text";
            this.Sigma_text.Size = new System.Drawing.Size(133, 34);
            this.Sigma_text.TabIndex = 4;
            this.Sigma_text.Text = "0.5";
            this.Sigma_text.TextChanged += new System.EventHandler(this.Sigma_text_TextChanged);
            // 
            // T_text
            // 
            this.T_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_text.Location = new System.Drawing.Point(124, 164);
            this.T_text.Name = "T_text";
            this.T_text.Size = new System.Drawing.Size(133, 34);
            this.T_text.TabIndex = 5;
            this.T_text.Text = "1";
            this.T_text.TextChanged += new System.EventHandler(this.T_text_TextChanged);
            // 
            // N_text
            // 
            this.N_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_text.Location = new System.Drawing.Point(124, 195);
            this.N_text.Name = "N_text";
            this.N_text.Size = new System.Drawing.Size(133, 34);
            this.N_text.TabIndex = 6;
            this.N_text.Text = "100";
            this.N_text.TextChanged += new System.EventHandler(this.N_text_TextChanged);
            // 
            // M_text
            // 
            this.M_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_text.Location = new System.Drawing.Point(124, 226);
            this.M_text.Name = "M_text";
            this.M_text.Size = new System.Drawing.Size(133, 34);
            this.M_text.TabIndex = 7;
            this.M_text.Text = "10000";
            this.M_text.TextChanged += new System.EventHandler(this.M_text_TextChanged);
            // 
            // btmCall
            // 
            this.btmCall.AutoSize = true;
            this.btmCall.Checked = true;
            this.btmCall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCall.Location = new System.Drawing.Point(38, 24);
            this.btmCall.Name = "btmCall";
            this.btmCall.Size = new System.Drawing.Size(65, 26);
            this.btmCall.TabIndex = 8;
            this.btmCall.TabStop = true;
            this.btmCall.Text = "Call";
            this.btmCall.UseVisualStyleBackColor = true;
            // 
            // btmPut
            // 
            this.btmPut.AutoSize = true;
            this.btmPut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPut.Location = new System.Drawing.Point(38, 56);
            this.btmPut.Name = "btmPut";
            this.btmPut.Size = new System.Drawing.Size(64, 26);
            this.btmPut.TabIndex = 9;
            this.btmPut.TabStop = true;
            this.btmPut.Text = "Puts";
            this.btmPut.UseVisualStyleBackColor = true;
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(16, 43);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(97, 22);
            this.lbS.TabIndex = 10;
            this.lbS.Text = "Underlying";
            this.lbS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbK
            // 
            this.lbK.AutoSize = true;
            this.lbK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbK.Location = new System.Drawing.Point(55, 74);
            this.lbK.Name = "lbK";
            this.lbK.Size = new System.Drawing.Size(57, 22);
            this.lbK.TabIndex = 11;
            this.lbK.Text = "Strike";
            this.lbK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR.Location = new System.Drawing.Point(2, 105);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(109, 22);
            this.lbR.TabIndex = 12;
            this.lbR.Text = "Interest Rate";
            this.lbR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSigma
            // 
            this.lbSigma.AutoSize = true;
            this.lbSigma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSigma.Location = new System.Drawing.Point(30, 136);
            this.lbSigma.Name = "lbSigma";
            this.lbSigma.Size = new System.Drawing.Size(82, 22);
            this.lbSigma.TabIndex = 13;
            this.lbSigma.Text = "Volatility";
            this.lbSigma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbT.Location = new System.Drawing.Point(54, 167);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(56, 22);
            this.lbT.TabIndex = 14;
            this.lbT.Text = "Tenor";
            this.lbT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN.Location = new System.Drawing.Point(57, 198);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(53, 22);
            this.lbN.TabIndex = 15;
            this.lbN.Text = "Steps";
            this.lbN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM.Location = new System.Drawing.Point(53, 229);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(57, 22);
            this.lbM.TabIndex = 16;
            this.lbM.Text = "Trails";
            this.lbM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSE
            // 
            this.lbSE.AutoSize = true;
            this.lbSE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSE.Location = new System.Drawing.Point(2, 224);
            this.lbSE.Name = "lbSE";
            this.lbSE.Size = new System.Drawing.Size(79, 22);
            this.lbSE.TabIndex = 33;
            this.lbSE.Text = "StdError";
            this.lbSE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSE.Click += new System.EventHandler(this.lbSE_Click);
            // 
            // lbRho
            // 
            this.lbRho.AutoSize = true;
            this.lbRho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRho.Location = new System.Drawing.Point(36, 196);
            this.lbRho.Name = "lbRho";
            this.lbRho.Size = new System.Drawing.Size(42, 22);
            this.lbRho.TabIndex = 32;
            this.lbRho.Text = "Rho";
            this.lbRho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTheta
            // 
            this.lbTheta.AutoSize = true;
            this.lbTheta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheta.Location = new System.Drawing.Point(27, 162);
            this.lbTheta.Name = "lbTheta";
            this.lbTheta.Size = new System.Drawing.Size(54, 22);
            this.lbTheta.TabIndex = 31;
            this.lbTheta.Text = "Theta";
            this.lbTheta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVega
            // 
            this.lbVega.AutoSize = true;
            this.lbVega.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVega.Location = new System.Drawing.Point(33, 131);
            this.lbVega.Name = "lbVega";
            this.lbVega.Size = new System.Drawing.Size(48, 22);
            this.lbVega.TabIndex = 30;
            this.lbVega.Text = "Vega";
            this.lbVega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGa
            // 
            this.lbGa.AutoSize = true;
            this.lbGa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGa.Location = new System.Drawing.Point(13, 100);
            this.lbGa.Name = "lbGa";
            this.lbGa.Size = new System.Drawing.Size(70, 22);
            this.lbGa.TabIndex = 29;
            this.lbGa.Text = "Gamma";
            this.lbGa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelta.Location = new System.Drawing.Point(30, 69);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(53, 22);
            this.lbDelta.TabIndex = 28;
            this.lbDelta.Text = "Delta";
            this.lbDelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbP
            // 
            this.lbP.AutoSize = true;
            this.lbP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP.Location = new System.Drawing.Point(29, 38);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(52, 22);
            this.lbP.TabIndex = 27;
            this.lbP.Text = "Price";
            this.lbP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SE_text
            // 
            this.SE_text.Enabled = false;
            this.SE_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SE_text.Location = new System.Drawing.Point(87, 224);
            this.SE_text.Name = "SE_text";
            this.SE_text.Size = new System.Drawing.Size(195, 34);
            this.SE_text.TabIndex = 24;
            // 
            // Rho_text
            // 
            this.Rho_text.Enabled = false;
            this.Rho_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rho_text.Location = new System.Drawing.Point(87, 193);
            this.Rho_text.Name = "Rho_text";
            this.Rho_text.Size = new System.Drawing.Size(195, 34);
            this.Rho_text.TabIndex = 23;
            // 
            // Theta_text
            // 
            this.Theta_text.Enabled = false;
            this.Theta_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Theta_text.Location = new System.Drawing.Point(87, 162);
            this.Theta_text.Name = "Theta_text";
            this.Theta_text.Size = new System.Drawing.Size(195, 34);
            this.Theta_text.TabIndex = 22;
            // 
            // Vega_text
            // 
            this.Vega_text.Enabled = false;
            this.Vega_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vega_text.Location = new System.Drawing.Point(87, 131);
            this.Vega_text.Name = "Vega_text";
            this.Vega_text.Size = new System.Drawing.Size(195, 34);
            this.Vega_text.TabIndex = 21;
            // 
            // Gamma_text
            // 
            this.Gamma_text.Enabled = false;
            this.Gamma_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gamma_text.Location = new System.Drawing.Point(87, 100);
            this.Gamma_text.Name = "Gamma_text";
            this.Gamma_text.Size = new System.Drawing.Size(195, 34);
            this.Gamma_text.TabIndex = 20;
            // 
            // Delta_text
            // 
            this.Delta_text.Enabled = false;
            this.Delta_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delta_text.Location = new System.Drawing.Point(87, 69);
            this.Delta_text.Name = "Delta_text";
            this.Delta_text.Size = new System.Drawing.Size(195, 34);
            this.Delta_text.TabIndex = 19;
            // 
            // Price_text
            // 
            this.Price_text.Enabled = false;
            this.Price_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_text.Location = new System.Drawing.Point(87, 38);
            this.Price_text.Name = "Price_text";
            this.Price_text.Size = new System.Drawing.Size(195, 34);
            this.Price_text.TabIndex = 18;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar.Location = new System.Drawing.Point(310, 324);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(312, 44);
            this.progressBar.TabIndex = 35;
            // 
            // Serror
            // 
            this.Serror.ContainerControl = this;
            // 
            // Kerror
            // 
            this.Kerror.ContainerControl = this;
            // 
            // Rerror
            // 
            this.Rerror.ContainerControl = this;
            // 
            // Verror
            // 
            this.Verror.ContainerControl = this;
            // 
            // Terror
            // 
            this.Terror.ContainerControl = this;
            // 
            // Nerror
            // 
            this.Nerror.ContainerControl = this;
            // 
            // Merror
            // 
            this.Merror.ContainerControl = this;
            // 
            // Outputs
            // 
            this.Outputs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Outputs.Controls.Add(this.Timer);
            this.Outputs.Controls.Add(this.Timer_text);
            this.Outputs.Controls.Add(this.lbSE);
            this.Outputs.Controls.Add(this.Price_text);
            this.Outputs.Controls.Add(this.Delta_text);
            this.Outputs.Controls.Add(this.lbRho);
            this.Outputs.Controls.Add(this.Gamma_text);
            this.Outputs.Controls.Add(this.lbTheta);
            this.Outputs.Controls.Add(this.Vega_text);
            this.Outputs.Controls.Add(this.lbVega);
            this.Outputs.Controls.Add(this.Theta_text);
            this.Outputs.Controls.Add(this.lbGa);
            this.Outputs.Controls.Add(this.Rho_text);
            this.Outputs.Controls.Add(this.lbDelta);
            this.Outputs.Controls.Add(this.SE_text);
            this.Outputs.Controls.Add(this.lbP);
            this.Outputs.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outputs.Location = new System.Drawing.Point(310, 8);
            this.Outputs.Name = "Outputs";
            this.Outputs.Size = new System.Drawing.Size(312, 302);
            this.Outputs.TabIndex = 36;
            this.Outputs.TabStop = false;
            this.Outputs.Text = "Outputs";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(22, 260);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(57, 22);
            this.Timer.TabIndex = 35;
            this.Timer.Text = "Timer";
            this.Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_text
            // 
            this.Timer_text.Enabled = false;
            this.Timer_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_text.Location = new System.Drawing.Point(87, 257);
            this.Timer_text.Name = "Timer_text";
            this.Timer_text.Size = new System.Drawing.Size(195, 34);
            this.Timer_text.TabIndex = 34;
            // 
            // Inputs
            // 
            this.Inputs.AutoSize = true;
            this.Inputs.Controls.Add(this.Sigma_text);
            this.Inputs.Controls.Add(this.S_text);
            this.Inputs.Controls.Add(this.K_text);
            this.Inputs.Controls.Add(this.lbM);
            this.Inputs.Controls.Add(this.r_text);
            this.Inputs.Controls.Add(this.lbN);
            this.Inputs.Controls.Add(this.T_text);
            this.Inputs.Controls.Add(this.lbT);
            this.Inputs.Controls.Add(this.N_text);
            this.Inputs.Controls.Add(this.lbSigma);
            this.Inputs.Controls.Add(this.M_text);
            this.Inputs.Controls.Add(this.lbR);
            this.Inputs.Controls.Add(this.lbS);
            this.Inputs.Controls.Add(this.lbK);
            this.Inputs.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inputs.Location = new System.Drawing.Point(12, 8);
            this.Inputs.Name = "Inputs";
            this.Inputs.Size = new System.Drawing.Size(292, 345);
            this.Inputs.TabIndex = 37;
            this.Inputs.TabStop = false;
            this.Inputs.Text = "Inputs";
            this.Inputs.Enter += new System.EventHandler(this.Inputs_Enter);
            // 
            // CallPut
            // 
            this.CallPut.AutoSize = true;
            this.CallPut.Controls.Add(this.btmCall);
            this.CallPut.Controls.Add(this.btmPut);
            this.CallPut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallPut.Location = new System.Drawing.Point(9, 324);
            this.CallPut.Name = "CallPut";
            this.CallPut.Size = new System.Drawing.Size(144, 111);
            this.CallPut.TabIndex = 38;
            this.CallPut.TabStop = false;
            this.CallPut.Text = "Call / Put";
            // 
            // Choices
            // 
            this.Choices.AutoSize = true;
            this.Choices.Controls.Add(this.multi);
            this.Choices.Controls.Add(this.CV);
            this.Choices.Controls.Add(this.Anthetic);
            this.Choices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choices.Location = new System.Drawing.Point(159, 324);
            this.Choices.Name = "Choices";
            this.Choices.Size = new System.Drawing.Size(136, 131);
            this.Choices.TabIndex = 39;
            this.Choices.TabStop = false;
            this.Choices.Text = "Choices";
            // 
            // multi
            // 
            this.multi.AutoSize = true;
            this.multi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(6, 76);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(124, 26);
            this.multi.TabIndex = 2;
            this.multi.Text = "Multithread";
            this.multi.UseVisualStyleBackColor = true;
            // 
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV.Location = new System.Drawing.Point(6, 49);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(111, 26);
            this.CV.TabIndex = 1;
            this.CV.Text = "CV_Delta";
            this.CV.UseVisualStyleBackColor = true;
            // 
            // Anthetic
            // 
            this.Anthetic.AutoSize = true;
            this.Anthetic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anthetic.Location = new System.Drawing.Point(6, 24);
            this.Anthetic.Name = "Anthetic";
            this.Anthetic.Size = new System.Drawing.Size(98, 26);
            this.Anthetic.TabIndex = 0;
            this.Anthetic.Text = "Anthetic";
            this.Anthetic.UseVisualStyleBackColor = true;
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu.Location = new System.Drawing.Point(640, 108);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(53, 22);
            this.cpu.TabIndex = 40;
            this.cpu.Text = "CPU:";
            // 
            // cpuCount
            // 
            this.cpuCount.AutoSize = true;
            this.cpuCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuCount.Location = new System.Drawing.Point(699, 108);
            this.cpuCount.Name = "cpuCount";
            this.cpuCount.Size = new System.Drawing.Size(20, 22);
            this.cpuCount.TabIndex = 41;
            this.cpuCount.Text = "4";
            // 
            // Monte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 493);
            this.Controls.Add(this.cpuCount);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.Choices);
            this.Controls.Add(this.CallPut);
            this.Controls.Add(this.Inputs);
            this.Controls.Add(this.Outputs);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btmGo);
            this.MaximizeBox = false;
            this.Name = "Monte";
            this.Text = "Monte Carlo Calculator";
            this.Load += new System.EventHandler(this.Monte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Serror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Verror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Terror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merror)).EndInit();
            this.Outputs.ResumeLayout(false);
            this.Outputs.PerformLayout();
            this.Inputs.ResumeLayout(false);
            this.Inputs.PerformLayout();
            this.CallPut.ResumeLayout(false);
            this.CallPut.PerformLayout();
            this.Choices.ResumeLayout(false);
            this.Choices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmGo;
        private System.Windows.Forms.TextBox S_text;
        private System.Windows.Forms.TextBox K_text;
        private System.Windows.Forms.TextBox r_text;
        private System.Windows.Forms.TextBox Sigma_text;
        private System.Windows.Forms.TextBox T_text;
        private System.Windows.Forms.TextBox N_text;
        private System.Windows.Forms.TextBox M_text;
        private System.Windows.Forms.RadioButton btmCall;
        private System.Windows.Forms.RadioButton btmPut;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Label lbSigma;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbSE;
        private System.Windows.Forms.Label lbRho;
        private System.Windows.Forms.Label lbTheta;
        private System.Windows.Forms.Label lbVega;
        private System.Windows.Forms.Label lbGa;
        private System.Windows.Forms.Label lbDelta;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.TextBox SE_text;
        private System.Windows.Forms.TextBox Rho_text;
        private System.Windows.Forms.TextBox Theta_text;
        private System.Windows.Forms.TextBox Vega_text;
        private System.Windows.Forms.TextBox Gamma_text;
        private System.Windows.Forms.TextBox Delta_text;
        private System.Windows.Forms.TextBox Price_text;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider Serror;
        private System.Windows.Forms.ErrorProvider Kerror;
        private System.Windows.Forms.ErrorProvider Rerror;
        private System.Windows.Forms.ErrorProvider Verror;
        private System.Windows.Forms.ErrorProvider Terror;
        private System.Windows.Forms.ErrorProvider Nerror;
        private System.Windows.Forms.ErrorProvider Merror;
        private System.Windows.Forms.GroupBox Inputs;
        private System.Windows.Forms.GroupBox Outputs;
        private System.Windows.Forms.GroupBox Choices;
        private System.Windows.Forms.CheckBox Anthetic;
        private System.Windows.Forms.GroupBox CallPut;
        private System.Windows.Forms.CheckBox CV;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.TextBox Timer_text;
        private System.Windows.Forms.Label cpuCount;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.CheckBox multi;
    }
}

