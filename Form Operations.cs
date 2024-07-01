using System;
using System.Windows.Forms;

public class MainForm : Form
{
    public MainForm()
    {
        // Formun başlık metni
        this.Text = "Ana Form";

        // Formun boyutları
        this.Width = 400;
        this.Height = 300;

        // Form gösterimi
        this.Show();
    }

    // Ana metot
    public static void Main()
    {
        Application.Run(new MainForm());
    }
}

public MainForm()
{
    // Formun başlık metni
    this.Text = "Ana Form";

    // Formun boyutları
    this.Width = 400;
    this.Height = 300;

    // Bir buton ekleyelim
    Button btn = new Button();
    btn.Text = "Tıkla";
    btn.Location = new System.Drawing.Point(150, 100);
    btn.Click += Btn_Click; // Butona tıklama olayı ekleme

    this.Controls.Add(btn); // Forma butonu ekleme

    // Form gösterimi
    this.Show();
}

private void Btn_Click(object sender, EventArgs e)
{
    MessageBox.Show("Butona Tıklandı!");
}