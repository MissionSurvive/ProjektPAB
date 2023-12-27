using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ClientOrderForm : Form
    {
        ZAMOWIENIA model = new ZAMOWIENIA();
        public ClientOrderForm()
        {
            InitializeComponent();
            using (CarRentalCWEntities db = new CarRentalCWEntities())
            {
                dataGridView1.DataSource = db.ZAMOWIENIA
                    .Join(db.PAKIETY, 
                    a => a.ID_PAKIET,  //zamowienia
                    b => b.ID_PAKIET,  //pakiety
                    (a,b) => new
                    {
                        id = a.ID_KLIENT,
                        a, b
                    })
                    .Where(a => a.id == LoginForm.userID)
                    .Join(db.WYPOZYCZALNIE,
                    c => c.a.ID_WYPOZYCZALNIA, //zamowienia
                    d => d.ID_WYPOZYCZALNIA,   //wypozyczalnie
                    (c, d) => new
                    {
                        c,d
                    })
                    .Join(db.HISTORIA_ZAMOWIENIA,
                    e => e.c.a.ID_HISTORIA,
                    f => f.ID_HISTORIA,
                    (e, f) => new
                    {
                        e,f
                    })
                    .Join(db.SAMOCHODY,
                    g => g.e.c.a.ID_SAMOCHOD,
                    h => h.ID_SAMOCHOD,
                    (g, h) => new
                    {
                        g,h
                    })
                    .Join(db.MODELE,
                    i => i.h.ID_MODEL,
                    j => j.ID_MODEL,
                    (i, j) => new
                    {
                        i,j
                    })
                    .Select(result => new
                    {
                        result.j.NAZWA_MODEL,
                        result.i.g.e.c.a.LICZBA_DNI,
                        result.i.g.e.c.a.CENA_ZAMOWIENIE,
                        result.i.g.e.c.a.DATA_START,
                        result.i.g.e.c.a.DATA_KONIEC,
                        result.i.g.e.d.MIASTO,
                        result.i.g.f.TANKOWANIE,
                        result.i.g.f.ILOSC_TANKOWANIE,
                        result.i.g.f.KOSZT_TANKOWANIE,
                        result.i.g.f.KARA_KOLIZJA,
                    }) 
                    .ToList();
            }
                
        }
    }
}
