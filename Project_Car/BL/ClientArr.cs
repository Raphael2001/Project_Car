using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Project_Car.DAL;

namespace Project_Car.BL
{
    public class ClientArr : ArrayList
    {
        public void Fill()
        {
            DataTable dataTable = Client_DAL.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות 

            //להעביר כל שורה בטבלה ללקוח 
            DataRow dataRow;
            Client client;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];


                client = new Client(dataRow);

                this.Add(client);
            }
        }

        public ClientArr Filter(int id, string Name, string PhoneNumber)
        {
            ClientArr clientArr = new ClientArr();

            for (int i = 0; i < this.Count; i++)
            {
                Client client = (this[i] as Client);
                if
                    (
                    (id <= 0 || client.Id == id)
                    && client.Fullname.Contains(Name)
                    && (client.PhoneNumber.Contains(PhoneNumber))
                    )
                    clientArr.Add(client);



            }
            return clientArr;
        }

        public bool DoesExist(City curCity)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Client).City.Id == curCity.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist(Street curStreet)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Street).Id == curStreet.Id)
                    return true;
            }
            return false;
        }

        public Client GetClient(int Id)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Client).Id == Id)
                {
                    return this[i] as Client;
                }
            }
            return null;
        }

        public Client GetClientWithMaxId()
        {
            Client client = new Client();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Client).Id > client.Id)
                {
                    client = this[i] as Client;
                }
            }
            return client;
        }

        public bool IsContains(Client client)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Client).Id == client.Id)
                    return true;

            }
            return false;
        }

        public new void Sort()
        {

            Client temp;
            Client c1, c2;
            for (int i = 0; i < this.Count; i++)
            {

                for (int j = i + 1; j < this.Count; j++)
                {
                    c1 = this[i] as Client;
                    c2 = this[j] as Client;

                    if ((this[i] as Client) != null && (this[j] as Client) != null)
                    {
                        if (c2.Count > c1.Count)
                        {

                            temp = c1;
                            c1 = c2;
                            c2 = temp;

                            this[i] = c1;
                            this[j] = c2;

                        }
                    }
                }
            }
        }

    }

}
