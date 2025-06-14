using Clydeackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clydeackend.Controllers
{ 
 
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : ControllerBase
    {
        private static readonly List<Recipe> Recipes = new()
        {
            new Recipe
            {
                Id = 1,
                Title = "Adobo",
                ImageUrl = "https://cdn.apartmenttherapy.info/image/upload/f_jpg,q_auto:eco,c_fill,g_auto,w_1500,ar_4:3/k%2FPhoto%2FRecipes%2F2024-04-filipino-adobo%2Ffilipino-adobo-426",
                Steps = new List<string>
                {
                    "Heat oil in a pan and sauté garlic.",
                    "Add pork and/or chicken and cook until browned.",
                    "Add soy sauce, vinegar, bay leaves, and peppercorns.",
                    "Simmer for 30–45 minutes until meat is tender.",
                    "Serve hot with rice."
                }
            },
            new Recipe
            {
                Id = 2,
                Title = "Sinigang na Baboy",
                ImageUrl = "https://yummykitchentv.com/wp-content/uploads/2023/02/sinigang-na-baboy.jpg",
                Steps = new List<string>
                {
                    "Boil pork ribs in water until tender.",
                    "Add tomatoes, onions, and gabi (taro).",
                    "Add vegetables like sitaw, kangkong, and eggplant.",
                    "Add tamarind mix or fresh sampalok.",
                    "Simmer until vegetables are cooked.",
                    "Serve hot with rice."
                }
            },
            new Recipe
            {
                Id = 3,
                Title = "Kare-Kare",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ac/Mac_MG_5939.jpg",
                Steps = new List<string>
                {
                    "Boil oxtail until tender.",
                    "Sauté garlic and onions in annatto oil.",
                    "Add boiled meat and peanut butter.",
                    "Add blanched vegetables: banana heart, string beans, pechay.",
                    "Serve with bagoong (shrimp paste)."
                }
            },
            new Recipe
            {
                Id = 4,
                Title = "Lechon Kawali",
                ImageUrl = "https://static01.nyt.com/images/2023/11/28/multimedia/ND-Lechon-Kawali-bflv/ND-Lechon-Kawali-bflv-mediumSquareAt3X.jpg",
                Steps = new List<string>
                {
                    "Boil pork belly with salt, bay leaves, and peppercorns.",
                    "Let it dry overnight or air dry.",
                    "Deep fry until crispy.",
                    "Slice and serve with lechon sauce."
                }
            },
            new Recipe
            {
                Id = 5,
                Title = "Pancit Canton",
                ImageUrl = "https://www.maggi.ph/sites/default/files/styles/home_stage_944_531/public/srh_recipes/5b661360b8e49f5c2348c06858bb8f57.jpg?h=4f5b30f1&itok=doXJkNdF",
                Steps = new List<string>
                {
                    "Sauté garlic, onions, and meats (chicken, pork, shrimp).",
                    "Add vegetables like cabbage and carrots.",
                    "Pour soy sauce and oyster sauce.",
                    "Add pancit canton noodles and broth.",
                    "Toss until noodles are cooked."
                }
            },
            new Recipe
            {
                Id = 6,
                Title = "Laing",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Laing%2C_Bicolano_dish.jpg/1200px-Laing%2C_Bicolano_dish.jpg",
                Steps = new List<string>
                {
                    "Sauté garlic, onions, and ginger in oil.",
                    "Add dried taro leaves without stirring.",
                    "Pour coconut milk and simmer on low heat.",
                    "Add chilies and season to taste.",
                    "Simmer until leaves are soft and cooked."
                }
            },
            new Recipe
            {
                Id = 7,
                Title = "Tinolang Manok",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiBcLWzfA7J6RB316VHl0vk1EqbzWPJGS1kQ&s",
                Steps = new List<string>
                {
                    "Sauté garlic, onion, and ginger.",
                    "Add chicken and cook until light brown.",
                    "Add water and bring to boil.",
                    "Add green papaya or sayote.",
                    "Add malunggay or chili leaves.",
                    "Simmer and serve hot."
                }
            },
            new Recipe
            {
                Id = 8,
                Title = "Bicol Express",
                ImageUrl = "https://yummykitchentv.com/wp-content/uploads/2023/02/creamy-bicol-express.jpg",
                Steps = new List<string>
                {
                    "Sauté garlic, onion, and ginger.",
                    "Add pork and cook until light brown.",
                    "Add coconut milk and simmer.",
                    "Add shrimp paste and chilies.",
                    "Simmer until thick and flavorful."
                }
            },
            new Recipe
            {
                Id = 9,
                Title = "Menudo",
                ImageUrl = "https://panlasangpinoy.com/wp-content/uploads/2014/04/Menudo-recipe.jpg",
                Steps = new List<string>
                {
                    "Sauté garlic and onion.",
                    "Add pork and liver cubes.",
                    "Add tomato sauce, potatoes, and carrots.",
                    "Add green peas and raisins.",
                    "Simmer until everything is tender."
                }
            },
            new Recipe
            {
                Id = 10,
                Title = "Tortang Talong",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1e/EGGPLANT_TORTA.jpg",
                Steps = new List<string>
                {
                    "Grill or boil eggplants and peel skin.",
                    "Flatten eggplants with fork.",
                    "Dip in beaten eggs with salt and pepper.",
                    "Pan fry until golden brown.",
                    "Serve with ketchup or soy sauce."
                }
            },
            new Recipe
            {
                Id = 11,
                Title = "Pakbet ",
                ImageUrl = "https://www.seriouseats.com/thmb/BHTueEcNShZmWVlwc4_VVmhfLYs=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/20210712-pinakbet-vicky-wasik-seriouseats-12-37ac6b9ea57145728de86f927dc5fef6.jpg",
                Steps = new List<string>
                {
                    "Sauté garlic, onions, and tomatoes.",
                    "Add shrimp paste and vegetables (bitter melon, squash, okra).",
                    "Simmer with a little water until cooked.",
                    "Do not over stir to keep veggies intact."
                }
            },
            new Recipe
            {
                Id = 12,
                Title = "Inihaw na Liempo",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWdlpVKw8ninh_xRFpNazIjrCsBZ-yFIKTAA&s",
                Steps = new List<string>
                {
                    "Marinate pork belly in soy sauce, calamansi, garlic, and pepper.",
                    "Let sit for at least 1 hour.",
                    "Grill over charcoal until cooked and slightly charred.",
                    "Slice and serve with dipping sauce."
                }
            },
            new Recipe
            {
                Id = 13,
                Title = "Tokwa’t Baboy",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfM86aydfGGT_YNgfaQ8bgjTXchGFbbY1thA&s",
                Steps = new List<string>
                {
                    "Boil pork ears and belly until tender then slice.",
                    "Fry tofu until crispy and cube it.",
                    "Mix soy sauce, vinegar, onions, garlic, and chilies.",
                    "Combine pork and tofu with the sauce."
                }
            },
            new Recipe
            {
                Id = 14,
                Title = "Ginataang Kalabasa at Sitaw",
                ImageUrl = "https://assets.unileversolutions.com/recipes-v2/214415.png",
                Steps = new List<string>
                {
                    "Sauté garlic and onions.",
                    "Add kalabasa (squash) and cook until slightly soft.",
                    "Add string beans and coconut milk.",
                    "Simmer until vegetables are tender.",
                    "Season with salt and pepper."
                }
            },
            new Recipe
            {
                Id = 15,
                Title = "Paksiw na Bangus",
                ImageUrl = "https://www.kawalingpinoy.com/wp-content/uploads/2021/07/paksiw-bangus.jpg",
                Steps = new List<string>
                {
                    "Layer bangus (milkfish), garlic, and onions in a pan.",
                    "Add vinegar, water, ginger, and pepper.",
                    "Add ampalaya (bitter gourd) if desired.",
                    "Simmer without stirring until cooked."
                }
            },
            new Recipe
            {
                Id = 16,
                Title = "Champorado",
                ImageUrl = "https://yummykitchentv.com/wp-content/uploads/2023/08/champorado-recipe.jpg",
                Steps = new List<string>
                {
                    "Boil glutinous rice in water.",
                    "Add cocoa powder or tablea and stir well.",
                    "Simmer until rice is soft.",
                    "Sweeten with sugar and serve hot or cold.",
                    "Top with milk or tuyo (dried fish)."
                }
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetRecipes()
        {
            return Ok(Recipes);
        }
    }
}