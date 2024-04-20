using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class EditorCategoryViewModel
    {
        /// <summary>
        /// Name
        /// </summary>
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve ter entre 3 e 40 caracteres")]
        public string Name { get; set; }


        /// <summary>
        /// Slug
        /// </summary>
        [Required(ErrorMessage = "O slug é obrigatório")]
        public string Slug { get; set; }
    }
}
