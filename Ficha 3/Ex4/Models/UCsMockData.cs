using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4.Models
{
    public class UCsMockData
    {
        private static List<UC> ucs;

        public static List<UC> ListaUCs
        {
            get
            {
                if(ucs == null)
                {
                    ucs = InitialData();
                }
                return ucs;
            }
        }

        public static void AddUc(UC nova)
        {
            if (nova != null && ListaUCs.Find(u => u.Id == nova.Id) != null)
                ucs.Add(nova);
        }


        private static List<UC> InitialData()
        {
            List<UC> ucs = new List<UC> {
                new UC {
                    Id= 1,
                    Nome="Programação Web",
                    ECTS= 6,
                    Licenciatura= "Engenharia Informática",
                    Semestre= 5,
                    Ramo="TC"
                },
                new UC {
                    Id= 2,
                    Nome="Arquiteturas Móveis",
                    ECTS= 6,
                    Licenciatura= "Engenharia Informática",
                    Semestre= 5,
                    Ramo= "DA"
                },
                new UC {
                    Id= 3,
                    Nome="Programação Distribuída",
                    ECTS= 6,
                    Licenciatura= "Engenharia Informática",
                    Semestre= 5,
                    Ramo= "DA"
                },
                new UC {
                    Id= 4,
                    Nome="Inteligência Computacional",
                    ECTS= 6,
                    Licenciatura= "Engenharia Informática",
                    Semestre= 5,
                    Ramo= "SI"
                }
            };

            return ucs;

        }
    }
}
