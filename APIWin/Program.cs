using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using APIWin;

class Program
{
    static void Main()
    {
        Form1 form = new Form1();
        Application.Run(form);
    }

    /*[DllImport("shell32.dll", CharSet = CharSet.Auto)]  
    public static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Tạo một form
        Form form = new Form();
        form.Text = "Ứng dụng Mở Tệp";
        form.Size = new System.Drawing.Size(400, 200);

        // Tạo textbox để nhập đường dẫn tệp
        TextBox textBox = new TextBox();
        textBox.Location = new System.Drawing.Point(10, 10);
        textBox.Size = new System.Drawing.Size(300, 24);

        // Tạo button để mở tệp
        Button openFileButton = new Button();
        openFileButton.Text = "Mở tệp";
        openFileButton.Location = new System.Drawing.Point(10, 40);
        openFileButton.Click += (sender, e) => OpenFile(textBox.Text);
        form.Controls.Add(textBox);
        form.Controls.Add(openFileButton);

        // Hiển thị form
        Application.Run(form);
    }

    static void OpenFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            ShellExecute(IntPtr.Zero, "open", filePath, null, null, 1);
        }
        else
        {
            MessageBox.Show("Tệp không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }*/
}
