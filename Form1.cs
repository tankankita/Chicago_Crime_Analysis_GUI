using System;
using System.Windows.Forms;


namespace ChicagoCrime
{
  public partial class Form1 : Form
  {
     public Form1()
    {
      InitializeComponent();
    }

    private bool doesFileExist(string filename)
    {
      if (!System.IO.File.Exists(filename))
      {
        string msg = string.Format("Input file not found: '{0}'",
          filename);

        MessageBox.Show(msg);
        return false;
      }
      return true;
    }

    private void clearForm()
    {
      if (this.graphPanel.Controls.Count > 0)
      {
        this.graphPanel.Controls.RemoveAt(0);
        this.graphPanel.Refresh();
      }
    }

    private void cmdByYear_Click(object sender, EventArgs e)
    {
      string filename = this.txtFilename.Text;
      if (!doesFileExist(filename))
        return;
      clearForm();
      this.Cursor = Cursors.WaitCursor;
      var chart = FSAnalysis.CrimesByYear(filename);
      this.Cursor = Cursors.Default;
      this.graphPanel.Controls.Add(chart);
            this.graphPanel.Refresh();
        }

     private void byarrest_Click(object sender, EventArgs e)
        {
            string filename = this.txtFilename.Text;
            if (!doesFileExist(filename))
                return;
            clearForm();
            this.Cursor = Cursors.WaitCursor;
            var chart2 = FSAnalysis.CrimesByArrest(filename);
            this.Cursor = Cursors.Default;
            this.graphPanel.Controls.Add(chart2);
            this.graphPanel.Refresh();
    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String IUCR = this.textBox1.Text;
            string filename = this.txtFilename.Text;
            if (!doesFileExist(filename))
                return;
            clearForm();
            this.Cursor = Cursors.WaitCursor;
            var chart2 = FSAnalysis.CrimesByCrime(filename, IUCR);
            this.Cursor = Cursors.Default;
            this.graphPanel.Controls.Add(chart2);
            this.graphPanel.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String area = this.textBox2.Text;
            string filename = this.txtFilename.Text;
            if (!doesFileExist(filename))
                return;
            clearForm();
            this.Cursor = Cursors.WaitCursor;
            var chart2 = FSAnalysis.CrimesByArea(filename, area);
            this.Cursor = Cursors.Default;
            this.graphPanel.Controls.Add(chart2);
            this.graphPanel.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = this.txtFilename.Text;
            if (!doesFileExist(filename))
                return;
            clearForm();
            this.Cursor = Cursors.WaitCursor;
            var chart2 = FSAnalysis.CrimesByChicago(filename);
            this.Cursor = Cursors.Default;
            this.graphPanel.Controls.Add(chart2);
            this.graphPanel.Refresh();
        }
    }
}
