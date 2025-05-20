namespace LocalRecyclers
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
            upperLeft_Panel = new Panel();
            url_Button = new Button();
            lastLine_Button = new Button();
            next_Button = new Button();
            prev_Button = new Button();
            firstLine_Button = new Button();
            name_TextBox = new TextBox();
            address_TextBox = new TextBox();
            phone_TextBox = new TextBox();
            recycles_TextBox = new TextBox();
            website_TextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            upperRight_Panel = new Panel();
            exit_Button = new Button();
            delete_Button = new Button();
            update_Button = new Button();
            addNew_Button = new Button();
            clear_Button = new Button();
            search_Button = new Button();
            label7 = new Label();
            search_TextBox = new TextBox();
            bottom_Panel = new Panel();
            filter_ComboBox = new ComboBox();
            label8 = new Label();
            recyclerListing_TextBox = new TextBox();
            label6 = new Label();
            upperLeft_Panel.SuspendLayout();
            upperRight_Panel.SuspendLayout();
            bottom_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // upperLeft_Panel
            // 
            upperLeft_Panel.BackColor = Color.FromArgb(192, 255, 192);
            upperLeft_Panel.Controls.Add(url_Button);
            upperLeft_Panel.Controls.Add(lastLine_Button);
            upperLeft_Panel.Controls.Add(next_Button);
            upperLeft_Panel.Controls.Add(prev_Button);
            upperLeft_Panel.Controls.Add(firstLine_Button);
            upperLeft_Panel.Controls.Add(name_TextBox);
            upperLeft_Panel.Controls.Add(address_TextBox);
            upperLeft_Panel.Controls.Add(phone_TextBox);
            upperLeft_Panel.Controls.Add(recycles_TextBox);
            upperLeft_Panel.Controls.Add(website_TextBox);
            upperLeft_Panel.Controls.Add(label5);
            upperLeft_Panel.Controls.Add(label4);
            upperLeft_Panel.Controls.Add(label3);
            upperLeft_Panel.Controls.Add(label2);
            upperLeft_Panel.Controls.Add(label1);
            upperLeft_Panel.Location = new Point(4, 4);
            upperLeft_Panel.Name = "upperLeft_Panel";
            upperLeft_Panel.Size = new Size(610, 395);
            upperLeft_Panel.TabIndex = 0;
            // 
            // url_Button
            // 
            url_Button.Location = new Point(449, 355);
            url_Button.Name = "url_Button";
            url_Button.Size = new Size(104, 23);
            url_Button.TabIndex = 14;
            url_Button.Text = "Go to URL";
            url_Button.UseVisualStyleBackColor = true;
            url_Button.MouseClick += url_Button_MouseClick;
            // 
            // lastLine_Button
            // 
            lastLine_Button.Location = new Point(368, 355);
            lastLine_Button.Name = "lastLine_Button";
            lastLine_Button.Size = new Size(75, 23);
            lastLine_Button.TabIndex = 13;
            lastLine_Button.Text = ">|";
            lastLine_Button.UseVisualStyleBackColor = true;
            lastLine_Button.Click += lastLine_Button_Click;
            // 
            // next_Button
            // 
            next_Button.Location = new Point(287, 355);
            next_Button.Name = "next_Button";
            next_Button.Size = new Size(75, 23);
            next_Button.TabIndex = 12;
            next_Button.Text = ">";
            next_Button.UseVisualStyleBackColor = true;
            next_Button.Click += next_Button_Click;
            // 
            // prev_Button
            // 
            prev_Button.Location = new Point(206, 355);
            prev_Button.Name = "prev_Button";
            prev_Button.Size = new Size(75, 23);
            prev_Button.TabIndex = 11;
            prev_Button.Text = "<";
            prev_Button.UseVisualStyleBackColor = true;
            prev_Button.Click += prev_Button_Click;
            // 
            // firstLine_Button
            // 
            firstLine_Button.Location = new Point(125, 355);
            firstLine_Button.Name = "firstLine_Button";
            firstLine_Button.Size = new Size(75, 23);
            firstLine_Button.TabIndex = 10;
            firstLine_Button.Text = "|<";
            firstLine_Button.UseVisualStyleBackColor = true;
            firstLine_Button.Click += firstLine_Button_Click;
            // 
            // name_TextBox
            // 
            name_TextBox.Location = new Point(125, 21);
            name_TextBox.Name = "name_TextBox";
            name_TextBox.Size = new Size(428, 23);
            name_TextBox.TabIndex = 9;
            // 
            // address_TextBox
            // 
            address_TextBox.Location = new Point(125, 53);
            address_TextBox.Name = "address_TextBox";
            address_TextBox.Size = new Size(428, 23);
            address_TextBox.TabIndex = 8;
            // 
            // phone_TextBox
            // 
            phone_TextBox.Location = new Point(125, 85);
            phone_TextBox.Name = "phone_TextBox";
            phone_TextBox.Size = new Size(428, 23);
            phone_TextBox.TabIndex = 7;
            // 
            // recycles_TextBox
            // 
            recycles_TextBox.Location = new Point(125, 149);
            recycles_TextBox.Multiline = true;
            recycles_TextBox.Name = "recycles_TextBox";
            recycles_TextBox.Size = new Size(428, 186);
            recycles_TextBox.TabIndex = 6;
            // 
            // website_TextBox
            // 
            website_TextBox.Location = new Point(125, 117);
            website_TextBox.Name = "website_TextBox";
            website_TextBox.Size = new Size(428, 23);
            website_TextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 149);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Recycles:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 117);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Website:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 85);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 53);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 21);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Business Name:";
            // 
            // upperRight_Panel
            // 
            upperRight_Panel.BackColor = Color.FromArgb(192, 255, 255);
            upperRight_Panel.Controls.Add(exit_Button);
            upperRight_Panel.Controls.Add(delete_Button);
            upperRight_Panel.Controls.Add(update_Button);
            upperRight_Panel.Controls.Add(addNew_Button);
            upperRight_Panel.Controls.Add(clear_Button);
            upperRight_Panel.Controls.Add(search_Button);
            upperRight_Panel.Controls.Add(label7);
            upperRight_Panel.Controls.Add(search_TextBox);
            upperRight_Panel.Location = new Point(620, 4);
            upperRight_Panel.Name = "upperRight_Panel";
            upperRight_Panel.Size = new Size(336, 395);
            upperRight_Panel.TabIndex = 1;
            // 
            // exit_Button
            // 
            exit_Button.Location = new Point(72, 355);
            exit_Button.Name = "exit_Button";
            exit_Button.Size = new Size(243, 23);
            exit_Button.TabIndex = 7;
            exit_Button.Text = "Exit";
            exit_Button.UseVisualStyleBackColor = true;
            exit_Button.Click += exit_Button_Click;
            // 
            // delete_Button
            // 
            delete_Button.Location = new Point(72, 217);
            delete_Button.Name = "delete_Button";
            delete_Button.Size = new Size(243, 23);
            delete_Button.TabIndex = 6;
            delete_Button.Text = "Delete Existing Record";
            delete_Button.UseVisualStyleBackColor = true;
            delete_Button.Click += delete_Button_Click;
            // 
            // update_Button
            // 
            update_Button.Location = new Point(72, 181);
            update_Button.Name = "update_Button";
            update_Button.Size = new Size(243, 23);
            update_Button.TabIndex = 5;
            update_Button.Text = "Update Existing Record";
            update_Button.UseVisualStyleBackColor = true;
            update_Button.MouseClick += update_Button_MouseClick;
            // 
            // addNew_Button
            // 
            addNew_Button.Location = new Point(72, 145);
            addNew_Button.Name = "addNew_Button";
            addNew_Button.Size = new Size(243, 23);
            addNew_Button.TabIndex = 4;
            addNew_Button.Text = "Add New Record";
            addNew_Button.UseVisualStyleBackColor = true;
            addNew_Button.MouseClick += addNew_Button_MouseClick;
            // 
            // clear_Button
            // 
            clear_Button.Location = new Point(72, 109);
            clear_Button.Name = "clear_Button";
            clear_Button.Size = new Size(243, 23);
            clear_Button.TabIndex = 3;
            clear_Button.Text = "Clear Fields";
            clear_Button.UseVisualStyleBackColor = true;
            clear_Button.Click += clear_Button_Click;
            // 
            // search_Button
            // 
            search_Button.Location = new Point(72, 53);
            search_Button.Name = "search_Button";
            search_Button.Size = new Size(243, 23);
            search_Button.TabIndex = 2;
            search_Button.Text = "Binary Search by Business Name";
            search_Button.UseVisualStyleBackColor = true;
            search_Button.Click += search_Button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 24);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 1;
            label7.Text = "Find:";
            // 
            // search_TextBox
            // 
            search_TextBox.Location = new Point(72, 21);
            search_TextBox.Name = "search_TextBox";
            search_TextBox.Size = new Size(243, 23);
            search_TextBox.TabIndex = 0;
            // 
            // bottom_Panel
            // 
            bottom_Panel.BackColor = Color.FromArgb(192, 192, 255);
            bottom_Panel.Controls.Add(filter_ComboBox);
            bottom_Panel.Controls.Add(label8);
            bottom_Panel.Controls.Add(recyclerListing_TextBox);
            bottom_Panel.Controls.Add(label6);
            bottom_Panel.Location = new Point(4, 405);
            bottom_Panel.Name = "bottom_Panel";
            bottom_Panel.Size = new Size(952, 229);
            bottom_Panel.TabIndex = 2;
            // 
            // filter_ComboBox
            // 
            filter_ComboBox.FormattingEnabled = true;
            filter_ComboBox.Location = new Point(79, 24);
            filter_ComboBox.Name = "filter_ComboBox";
            filter_ComboBox.Size = new Size(121, 23);
            filter_ComboBox.TabIndex = 3;
            filter_ComboBox.SelectedIndexChanged += filter_ComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 24);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 2;
            label8.Text = "Filter by:";
            // 
            // recyclerListing_TextBox
            // 
            recyclerListing_TextBox.Location = new Point(20, 71);
            recyclerListing_TextBox.Multiline = true;
            recyclerListing_TextBox.Name = "recyclerListing_TextBox";
            recyclerListing_TextBox.Size = new Size(911, 147);
            recyclerListing_TextBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 53);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 0;
            label6.Text = "Recycler Listing:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 635);
            Controls.Add(bottom_Panel);
            Controls.Add(upperRight_Panel);
            Controls.Add(upperLeft_Panel);
            Name = "Form1";
            Text = "Local Recyclers";
            upperLeft_Panel.ResumeLayout(false);
            upperLeft_Panel.PerformLayout();
            upperRight_Panel.ResumeLayout(false);
            upperRight_Panel.PerformLayout();
            bottom_Panel.ResumeLayout(false);
            bottom_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel upperLeft_Panel;
        private Panel upperRight_Panel;
        private Panel bottom_Panel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button url_Button;
        private Button lastLine_Button;
        private Button next_Button;
        private Button prev_Button;
        private Button firstLine_Button;
        private TextBox name_TextBox;
        private TextBox address_TextBox;
        private TextBox phone_TextBox;
        private TextBox recycles_TextBox;
        private TextBox website_TextBox;
        private TextBox recyclerListing_TextBox;
        private Label label6;
        private Button exit_Button;
        private Button delete_Button;
        private Button update_Button;
        private Button addNew_Button;
        private Button clear_Button;
        private Button search_Button;
        private Label label7;
        private TextBox search_TextBox;
        private ComboBox filter_ComboBox;
        private Label label8;
    }
}
