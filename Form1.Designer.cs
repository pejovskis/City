namespace City
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerete = new Button();
            lblId = new Label();
            lblName = new Label();
            lblTimeToRepair = new Label();
            lblTimeToUpgrade = new Label();
            lblPriceToUpgrade = new Label();
            lblQuality = new Label();
            lblDescription = new Label();
            lblOwner = new Label();
            lblSold = new Label();
            lblIsBankrupt = new Label();
            lblLevel = new Label();
            lblSize = new Label();
            lblBruttoInCome = new Label();
            lblWorkerCapacity = new Label();
            lblEfficiency = new Label();
            lblHealth = new Label();
            lblInMaintenance = new Label();
            lblPriceBuy = new Label();
            lblTaxPay = new Label();
            lblBankruptTolerance = new Label();
            lblPricePromote = new Label();
            lblPriceRepair = new Label();
            lblPriceSell = new Label();
            lblNettoInCome = new Label();
            lblCustomerSatisfiction = new Label();
            lblExpenses = new Label();
            lblWin = new Label();
            lblRating = new Label();
            lblWorkersEmployed = new Label();
            lblPlayerCapital = new Label();
            lblPlayerName = new Label();
            lblPlayerId = new Label();
            lblPlayerBuildings = new Label();
            lblTimeLastingPromotion = new Label();
            SuspendLayout();
            // 
            // btnGenerete
            // 
            btnGenerete.Location = new Point(37, 37);
            btnGenerete.Name = "btnGenerete";
            btnGenerete.Size = new Size(75, 23);
            btnGenerete.TabIndex = 0;
            btnGenerete.Text = "Generete";
            btnGenerete.UseVisualStyleBackColor = true;
            btnGenerete.Click += button1_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(68, 80);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id:";
            lblId.Click += lblTimeToUpgrade_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(68, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblTimeToRepair
            // 
            lblTimeToRepair.AutoSize = true;
            lblTimeToRepair.Location = new Point(70, 291);
            lblTimeToRepair.Name = "lblTimeToRepair";
            lblTimeToRepair.Size = new Size(87, 15);
            lblTimeToRepair.TabIndex = 3;
            lblTimeToRepair.Text = "Time To Repair:";
            // 
            // lblTimeToUpgrade
            // 
            lblTimeToUpgrade.AutoSize = true;
            lblTimeToUpgrade.Location = new Point(70, 306);
            lblTimeToUpgrade.Name = "lblTimeToUpgrade";
            lblTimeToUpgrade.Size = new Size(99, 15);
            lblTimeToUpgrade.TabIndex = 4;
            lblTimeToUpgrade.Text = "Time To Upgrade:";
            // 
            // lblPriceToUpgrade
            // 
            lblPriceToUpgrade.AutoSize = true;
            lblPriceToUpgrade.Location = new Point(67, 365);
            lblPriceToUpgrade.Name = "lblPriceToUpgrade";
            lblPriceToUpgrade.Size = new Size(99, 15);
            lblPriceToUpgrade.TabIndex = 5;
            lblPriceToUpgrade.Text = "Price To Upgrade:";
            // 
            // lblQuality
            // 
            lblQuality.AutoSize = true;
            lblQuality.Location = new Point(67, 110);
            lblQuality.Name = "lblQuality";
            lblQuality.Size = new Size(48, 15);
            lblQuality.TabIndex = 6;
            lblQuality.Text = "Quality:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(67, 125);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description:";
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Location = new Point(67, 140);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(45, 15);
            lblOwner.TabIndex = 8;
            lblOwner.Text = "Owner:";
            // 
            // lblSold
            // 
            lblSold.AutoSize = true;
            lblSold.Location = new Point(67, 155);
            lblSold.Name = "lblSold";
            lblSold.Size = new Size(33, 15);
            lblSold.TabIndex = 9;
            lblSold.Text = "Sold:";
            // 
            // lblIsBankrupt
            // 
            lblIsBankrupt.AutoSize = true;
            lblIsBankrupt.Location = new Point(67, 185);
            lblIsBankrupt.Name = "lblIsBankrupt";
            lblIsBankrupt.Size = new Size(69, 15);
            lblIsBankrupt.TabIndex = 10;
            lblIsBankrupt.Text = "is Bankrupt:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(67, 200);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(37, 15);
            lblLevel.TabIndex = 11;
            lblLevel.Text = "Level:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(67, 215);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(30, 15);
            lblSize.TabIndex = 12;
            lblSize.Text = "Size:";
            // 
            // lblBruttoInCome
            // 
            lblBruttoInCome.AutoSize = true;
            lblBruttoInCome.Location = new Point(67, 440);
            lblBruttoInCome.Name = "lblBruttoInCome";
            lblBruttoInCome.Size = new Size(91, 15);
            lblBruttoInCome.TabIndex = 13;
            lblBruttoInCome.Text = "Brutto In Come:";
            // 
            // lblWorkerCapacity
            // 
            lblWorkerCapacity.AutoSize = true;
            lblWorkerCapacity.Location = new Point(67, 230);
            lblWorkerCapacity.Name = "lblWorkerCapacity";
            lblWorkerCapacity.Size = new Size(97, 15);
            lblWorkerCapacity.TabIndex = 14;
            lblWorkerCapacity.Text = "Worker Capacity:";
            lblWorkerCapacity.Click += lblWorkerCapacity_Click;
            // 
            // lblEfficiency
            // 
            lblEfficiency.AutoSize = true;
            lblEfficiency.Location = new Point(70, 276);
            lblEfficiency.Name = "lblEfficiency";
            lblEfficiency.Size = new Size(61, 15);
            lblEfficiency.TabIndex = 15;
            lblEfficiency.Text = "Efficiency:";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(70, 261);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(45, 15);
            lblHealth.TabIndex = 16;
            lblHealth.Text = "Health:";
            lblHealth.Click += label7_Click;
            // 
            // lblInMaintenance
            // 
            lblInMaintenance.AutoSize = true;
            lblInMaintenance.Location = new Point(67, 170);
            lblInMaintenance.Name = "lblInMaintenance";
            lblInMaintenance.Size = new Size(92, 15);
            lblInMaintenance.TabIndex = 17;
            lblInMaintenance.Text = "in Maintenance:";
            // 
            // lblPriceBuy
            // 
            lblPriceBuy.AutoSize = true;
            lblPriceBuy.Location = new Point(67, 335);
            lblPriceBuy.Name = "lblPriceBuy";
            lblPriceBuy.Size = new Size(59, 15);
            lblPriceBuy.TabIndex = 18;
            lblPriceBuy.Text = "Price Buy:";
            // 
            // lblTaxPay
            // 
            lblTaxPay.AutoSize = true;
            lblTaxPay.Location = new Point(65, 425);
            lblTaxPay.Name = "lblTaxPay";
            lblTaxPay.Size = new Size(49, 15);
            lblTaxPay.TabIndex = 20;
            lblTaxPay.Text = "Tax Pay:";
            // 
            // lblBankruptTolerance
            // 
            lblBankruptTolerance.AutoSize = true;
            lblBankruptTolerance.Location = new Point(67, 350);
            lblBankruptTolerance.Name = "lblBankruptTolerance";
            lblBankruptTolerance.Size = new Size(111, 15);
            lblBankruptTolerance.TabIndex = 21;
            lblBankruptTolerance.Text = "Bankrupt Tolerance:";
            // 
            // lblPricePromote
            // 
            lblPricePromote.AutoSize = true;
            lblPricePromote.Location = new Point(67, 395);
            lblPricePromote.Name = "lblPricePromote";
            lblPricePromote.Size = new Size(85, 15);
            lblPricePromote.TabIndex = 22;
            lblPricePromote.Text = "Price Promote:";
            // 
            // lblPriceRepair
            // 
            lblPriceRepair.AutoSize = true;
            lblPriceRepair.Location = new Point(67, 380);
            lblPriceRepair.Name = "lblPriceRepair";
            lblPriceRepair.Size = new Size(72, 15);
            lblPriceRepair.TabIndex = 23;
            lblPriceRepair.Text = "Price Repair:";
            // 
            // lblPriceSell
            // 
            lblPriceSell.AutoSize = true;
            lblPriceSell.Location = new Point(67, 410);
            lblPriceSell.Name = "lblPriceSell";
            lblPriceSell.Size = new Size(57, 15);
            lblPriceSell.TabIndex = 24;
            lblPriceSell.Text = "Price Sell:";
            // 
            // lblNettoInCome
            // 
            lblNettoInCome.AutoSize = true;
            lblNettoInCome.Location = new Point(67, 455);
            lblNettoInCome.Name = "lblNettoInCome";
            lblNettoInCome.Size = new Size(88, 15);
            lblNettoInCome.TabIndex = 25;
            lblNettoInCome.Text = "Netto In Come:";
            // 
            // lblCustomerSatisfiction
            // 
            lblCustomerSatisfiction.AutoSize = true;
            lblCustomerSatisfiction.Location = new Point(65, 500);
            lblCustomerSatisfiction.Name = "lblCustomerSatisfiction";
            lblCustomerSatisfiction.Size = new Size(126, 15);
            lblCustomerSatisfiction.TabIndex = 26;
            lblCustomerSatisfiction.Text = "Customer Satisfaction:";
            // 
            // lblExpenses
            // 
            lblExpenses.AutoSize = true;
            lblExpenses.Location = new Point(67, 470);
            lblExpenses.Name = "lblExpenses";
            lblExpenses.Size = new Size(58, 15);
            lblExpenses.TabIndex = 27;
            lblExpenses.Text = "Expenses:";
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.Location = new Point(66, 485);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(31, 15);
            lblWin.TabIndex = 28;
            lblWin.Text = "Win:";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(65, 515);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(44, 15);
            lblRating.TabIndex = 30;
            lblRating.Text = "Rating:";
            // 
            // lblWorkersEmployed
            // 
            lblWorkersEmployed.AutoSize = true;
            lblWorkersEmployed.Location = new Point(68, 245);
            lblWorkersEmployed.Name = "lblWorkersEmployed";
            lblWorkersEmployed.Size = new Size(109, 15);
            lblWorkersEmployed.TabIndex = 31;
            lblWorkersEmployed.Text = "Workers Employed:";
            // 
            // lblPlayerCapital
            // 
            lblPlayerCapital.AutoSize = true;
            lblPlayerCapital.Location = new Point(503, 110);
            lblPlayerCapital.Name = "lblPlayerCapital";
            lblPlayerCapital.Size = new Size(47, 15);
            lblPlayerCapital.TabIndex = 35;
            lblPlayerCapital.Text = "Capital:";
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(504, 95);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(42, 15);
            lblPlayerName.TabIndex = 34;
            lblPlayerName.Text = "Name:";
            // 
            // lblPlayerId
            // 
            lblPlayerId.AutoSize = true;
            lblPlayerId.Location = new Point(504, 80);
            lblPlayerId.Name = "lblPlayerId";
            lblPlayerId.Size = new Size(20, 15);
            lblPlayerId.TabIndex = 33;
            lblPlayerId.Text = "Id:";
            // 
            // lblPlayerBuildings
            // 
            lblPlayerBuildings.AutoSize = true;
            lblPlayerBuildings.Location = new Point(504, 125);
            lblPlayerBuildings.Name = "lblPlayerBuildings";
            lblPlayerBuildings.Size = new Size(100, 15);
            lblPlayerBuildings.TabIndex = 36;
            lblPlayerBuildings.Text = "Owned Buildings:";
            // 
            // lblTimeLastingPromotion
            // 
            lblTimeLastingPromotion.AutoSize = true;
            lblTimeLastingPromotion.Location = new Point(67, 320);
            lblTimeLastingPromotion.Name = "lblTimeLastingPromotion";
            lblTimeLastingPromotion.Size = new Size(134, 15);
            lblTimeLastingPromotion.TabIndex = 37;
            lblTimeLastingPromotion.Text = "Time Lasting Promotion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 626);
            Controls.Add(lblTimeLastingPromotion);
            Controls.Add(lblPlayerBuildings);
            Controls.Add(lblPlayerCapital);
            Controls.Add(lblPlayerName);
            Controls.Add(lblPlayerId);
            Controls.Add(lblWorkersEmployed);
            Controls.Add(lblRating);
            Controls.Add(lblWin);
            Controls.Add(lblExpenses);
            Controls.Add(lblCustomerSatisfiction);
            Controls.Add(lblNettoInCome);
            Controls.Add(lblPriceSell);
            Controls.Add(lblPriceRepair);
            Controls.Add(lblPricePromote);
            Controls.Add(lblBankruptTolerance);
            Controls.Add(lblTaxPay);
            Controls.Add(lblPriceBuy);
            Controls.Add(lblInMaintenance);
            Controls.Add(lblHealth);
            Controls.Add(lblEfficiency);
            Controls.Add(lblWorkerCapacity);
            Controls.Add(lblBruttoInCome);
            Controls.Add(lblSize);
            Controls.Add(lblLevel);
            Controls.Add(lblIsBankrupt);
            Controls.Add(lblSold);
            Controls.Add(lblOwner);
            Controls.Add(lblDescription);
            Controls.Add(lblQuality);
            Controls.Add(lblPriceToUpgrade);
            Controls.Add(lblTimeToUpgrade);
            Controls.Add(lblTimeToRepair);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(btnGenerete);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerete;
        private Label lblId;
        private Label lblName;
        private Label lblTimeToRepair;
        private Label lblTimeToUpgrade;
        private Label lblPriceToUpgrade;
        private Label lblQuality;
        private Label lblDescription;
        private Label lblOwner;
        private Label lblSold;
        private Label lblIsBankrupt;
        private Label lblLevel;
        private Label lblSize;
        private Label lblBruttoInCome;
        private Label lblWorkerCapacity;
        private Label lblEfficiency;
        private Label lblHealth;
        private Label lblInMaintenance;
        private Label lblPriceBuy;
        private Label lblTaxPay;
        private Label lblBankruptTolerance;
        private Label lblPricePromote;
        private Label lblPriceRepair;
        private Label lblPriceSell;
        private Label lblNettoInCome;
        private Label lblCustomerSatisfiction;
        private Label lblExpenses;
        private Label lblWin;
        private Label lblRating;
        private Label lblWorkersEmployed;
        private Label lblPlayerCapital;
        private Label lblPlayerName;
        private Label lblPlayerId;
        private Label lblPlayerBuildings;
        private Label lblTimeLastingPromotion;
    }
}