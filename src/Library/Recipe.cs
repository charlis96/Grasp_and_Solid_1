//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public ArrayList steps { get; } = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /*
        La clase Recipe es la que contiene toda la información necesaria para calcular el costo total
        de la receta, es la "experta". Por el principio Expert, debería ser la responsable de calcular
        el costo total.

        Con el siguiente método se calcula el costo total, el cual consiste en realizar la sumatoria
        de los subtotales de cada paso de la receta.
        */
        public double GetProductionCost()
        {
            double total = 0;
            foreach (Step step in this.steps)
            {
                total += step.GetSubTotal();
            }
            return total;
        }
    }
}