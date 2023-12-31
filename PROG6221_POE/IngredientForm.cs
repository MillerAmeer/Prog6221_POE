﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POE
{
   
   
    public partial class IngredientForm : Form
    {

        class Delegate_Calories
        {
            public delegate void Calorie();

            public class Delegate_calories
            {

                public void error_display()
                {

                    MessageBox.Show("Warning this recipe calories exceed 300!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                public void caloriesHealthy()
                {

                    MessageBox.Show("Recipe is healthy", "Healthy", MessageBoxButtons.OK);

                }


            }
        }
        private Recipes recipe;
        private List<Ingredients> Ingredient;
        
        public IngredientForm(Recipes recipes)
        {
            InitializeComponent();
            this.recipe = recipes;
            Ingredient = new List<Ingredients>();

        }
        

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {


              
                string ingredient = IngredientTextBox.Text;
                double quantity = double.Parse(QuantitytextBox.Text);
                string unit = UnitOfMeasuretextBox.Text;
                int calories = int.Parse(CaloriestextBox.Text);
                string foodGrp = FoodGroupcomboBox.SelectedItem.ToString();

                Ingredients ingredients = new Ingredients(ingredient, quantity, unit, calories, foodGrp);
                Ingredient.Add(ingredients);
                MessageBox.Show("Ingredient added successfully", "Added", MessageBoxButtons.OK);

              
                IngredientTextBox.Text = "";
                UnitOfMeasuretextBox.Text = "";
                QuantitytextBox.Text = "";
                CaloriestextBox.Text = "";
                FoodGroupcomboBox.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error! please fill in the appropriate fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            try
            {


                Delegate_Calories.Delegate_calories delegate_Calories = new Delegate_Calories.Delegate_calories();

                recipe.ingredients.AddRange(Ingredient);

              
                int totalCalories = Ingredient.Sum(i => i.Calories);

                if (totalCalories > 300)
                {
                    delegate_Calories.error_display();


                }
                else
                {
                    delegate_Calories.caloriesHealthy();


                }
              
                StepsForm SF = new StepsForm(recipe);

                SF.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("Error! try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    


    }
}

