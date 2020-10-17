using Project_Car.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Car.BL
{
    public class CarDesign
    {
        #region Members
        private int m_Id;
        private CarColor m_carColor;
        private ColorType m_ColorType;
        private BodyDesign m_BodyDesign;

        public int Id { get => m_Id; set => m_Id = value; }
        public CarColor CarColor { get => m_carColor; set => m_carColor = value; }
        public ColorType ColorType { get => m_ColorType; set => m_ColorType = value; }
        public BodyDesign BodyDesign { get => m_BodyDesign; set => m_BodyDesign = value; }

        #endregion


        public bool Insert()
        {
            return CarDesign_DAL.Insert(m_carColor.Id, m_ColorType.Id, m_BodyDesign.Id);
        }

        public bool Update()
        {
            return CarDesign_DAL.Update(m_Id, m_carColor.Id, m_ColorType.Id, m_BodyDesign.Id);
        }

        public bool Delete()
        {
            return CarDesign_DAL.Delete(m_Id);
        }

       

        public override string ToString()
        {
            if (m_BodyDesign.Name != "(None)")
            {
                return m_carColor.Name + " " + m_ColorType.Name + " - " + m_BodyDesign.Name;
            }
            else
            {
                return m_carColor.Name + " " + m_ColorType.Name;
            }
        }

        public string FullDesign
        {
            get
            {
                if (m_BodyDesign.Name == "(None)")
                {
                    return m_carColor.Name + " " + m_ColorType.Name;
                }
                else
                {
                    return m_carColor.Name + " " + m_ColorType.Name + " - " + m_BodyDesign.Name;

                }
            }
        }

        public CarDesign(DataRow dataRow)
        {
            this.m_Id = (int)dataRow["ID"];
            this.m_carColor = new CarColor(dataRow.GetParentRow("CarcarColor"));
            this.m_ColorType = new ColorType(dataRow.GetParentRow("CarColorType"));
            this.m_BodyDesign = new BodyDesign(dataRow.GetParentRow("CarBodyDesign"));
        }

        public CarDesign()
        {

        }

        



    }
}
