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
                    .Join(db.MARKI,
                    k => k.j.ID_MARKA,
                    l => l.ID_MARKA,
                    (k, l) => new
                    {
                        k,l
                    })
                    .Join(db.RODZAJE_NADWOZIA,
                    m => m.k.j.ID_NADWOZIE,
                    n => n.ID_NADWOZIE,
                    (m, n) => new
                    {
                        m, n
                    })
                    .Select(result => new
                    {
                        result.m.k.i.g.e.c.b.NAZWA,
                        result.m.k.i.g.e.d.MIASTO,
                        result.m.l.NAZWA_MARKA,
                        result.m.k.j.NAZWA_MODEL,
                        result.n.NAZWA_NADWOZIE,
                        result.m.k.i.h.KOLOR,
                        result.m.k.i.h.MOC,
                        result.m.k.i.h.SKRZYNIA,
                        result.m.k.i.h.MIEJSCA,
                        result.m.k.i.h.CENA_DZIEN,
                        result.m.k.i.h.CENA_TYDZIEN,
                        result.m.k.i.h.CENA_MIESIAC,
                        result.m.k.i.h.KAUCJA,
                        result.m.k.i.g.e.c.a.DATA_START,
                        result.m.k.i.g.e.c.a.DATA_KONIEC,
                        result.m.k.i.g.f.ILOSC_TANKOWANIE,
                        result.m.k.i.g.f.KOSZT_TANKOWANIE,
                        result.m.k.i.g.f.KARA_KOLIZJA,
                        result.m.k.i.g.e.c.a.ID_ZAMOWIENIE,
                    }) 
                    .ToList();
            }     
        }
    }
}
