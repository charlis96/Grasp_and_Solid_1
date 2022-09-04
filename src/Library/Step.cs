//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Product Input { get; set; }
        public double Quantity { get; set; }
        public int Time { get; set; }
        public Equipment Equipment { get; set; }

        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }
        //Con el siguiente método se calcula el subtotal de un paso, utilizando el costo unitario del
        //producto que se utiliza, así como también teniendo en cuenta el costo del equipamiento utilizado.
        public double GetSubTotal()
        {
            return this.Quantity * this.Input.UnitCost + this.Time * this.Equipment.HourlyCost / 3600;
        }
    }
}