using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracownicyKlient
{
    public partial class PracownicyForm : Form
    {
        public PracownicyForm()
        {
            InitializeComponent();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {

            if ((ImieBox.TextLength == 0) || (NazwiskoBox.TextLength == 0))
            {
                MessageBox.Show("Proszę podać poprawne imię i nazwisko");
            }
            else if (PESELBox.TextLength != 11)
            {
                MessageBox.Show("PESEL powinien zawierać 11 cyfr");
                
            }
            else
            {
                PracownicyReference.ServicePracownicyClient usluga = new PracownicyReference.ServicePracownicyClient();
                PracownicyReference.Pracownik p = new PracownicyReference.Pracownik();
                p.Imie = ImieBox.Text;
                p.Nazwisko = NazwiskoBox.Text;
                p.PESEL = PESELBox.Text;
                int sprawdz = usluga.DodajPracownika(p);
                if (sprawdz == 1)
                {
                    MessageBox.Show("Dodano Pracownika");
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd: podany pracownik już istnieje", "Klient usługi Pracownicy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void WczytajButton_Click(object sender, EventArgs e)
        {
            PracownicyReference.ServicePracownicyClient usluga = new PracownicyReference.ServicePracownicyClient();
            PracownicyReference.Pracownik p = new PracownicyReference.Pracownik();
            p.PESEL = PESELBox.Text;

            MessageBox.Show(usluga.WczytajPracownika(p));
        }

        private void SprawdzButton_Click(object sender, EventArgs e)
        {
            PracownicyReference.ServicePracownicyClient usluga = new PracownicyReference.ServicePracownicyClient();
            PracownicyReference.Pracownik p = new PracownicyReference.Pracownik();
            p.PESEL = PESELBox.Text;
            int sprawdz = usluga.SprawdzPracownika(p);
            if (sprawdz == 1)
            {
                MessageBox.Show("Pracownik o podanym nr. PESEL jest w bazie danych");
            }
            else
            {
                MessageBox.Show("Brak takiego Pracownika w bazie danych");
            }
            
            

        }

        private void UsunButton_Click(object sender, EventArgs e)
        {
            PracownicyReference.ServicePracownicyClient usluga = new PracownicyReference.ServicePracownicyClient();
            PracownicyReference.Pracownik p = new PracownicyReference.Pracownik();
            p.PESEL = PESELBox.Text;
            DialogResult dialog = MessageBox.Show("Czy napewno chcesz usunąć pracownika z bazy danych? ","Klient usługi Pracownicy",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                int usun = usluga.UsunPracownika(p);
                if (usun == 1)
                {
                    MessageBox.Show("Usunięto pracownika z bazy danych");
                }
                else
                {
                    MessageBox.Show("Brak takiego Pracownika w bazie danych");
                }
            }
            return;
            
        }


        private void PESELBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ImieBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void NazwiskoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        
    }
}
