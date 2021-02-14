using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// dama olması için ekranda 64 adet buton istiyoruz.
			// her buton bir class'ı temsil eder.
			// döngü yaparsak üst üste koyar butonları.
			Button[,] buttons = new Button[8,8];
			// 8e 8lik array ile oluşturduk böylelikle kontrol kolaylaştı
			int top = 0; // her seferde butonları kaydırmak gerekiyor bu yüzden üst ve soldan değerler eklenerek ilerletilecek.
			int left = 0; // 50ye 50lik butonlar olduğu için her seferde o şekilde değişecek.
			for (int i = 0; i < buttons.GetUpperBound(0); i++) // x ekseni için 0-7 arası değerleri için
			{
				for (int j = 0; j < buttons.GetUpperBound(1); j++) // y ekseni için 0-7 arası değerleri için
				{
					buttons[i, j] = new Button(); // her seferinde koordinatlar ilerletilerek yeni bir buton oluşturulacak
					buttons[i, j].Width = 50;
					buttons[i, j].Height = 50;
					buttons[i, j].Left = left;
					buttons[i, j].Top = top;
					left += 50;
					if ((i+j)%2==0) // renklendirme
					{
						buttons[i, j].BackColor = Color.Black;
					}
					else
					{
						buttons[i, j].BackColor = Color.White;
					}
					this.Controls.Add(buttons[i, j]);
				}
				top += 50;
				left = 0;

			}
			
		}
	}
}
