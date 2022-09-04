using System;

namespace Full_GRASP_And_SOLID.Library;

public class ConsolePrinter
{
    /*
    Se retira el método PrintRecipe de la clase Recipe ya que si se quisiera cambiar el formato
    de cómo se imprime la receta, habría que cambiar esa clase, y la misma ya tiene otra responsabilidad.
    Utilizo el principio SRP.
    */
    public ConsolePrinter(Recipe recipe)
    {
        Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
        foreach (Step step in recipe.steps)
        {
            Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                $"usando '{step.Equipment.Description}' durante {step.Time} segundos.");
        }
        Console.WriteLine($"Costo total: ${recipe.GetProductionCost()}");
    }
}