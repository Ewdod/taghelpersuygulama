using Microsoft.AspNetCore.Razor.TagHelpers;

namespace taghelpersuygulama.TagHelpers
{
    [HtmlTargetElement("uyum")]
    public class Uyum : TagHelper
    {
        public string Cumle { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (Cumle != null)
            {
                KalinInceUyumu(Cumle);

            }
        }


        static bool KalinInceUyumu(string kelime)
        {
            //kelime = kelime.ToLower(); // Kelimeyi küçük harflere çevir
            var kalinUnluHarfler = new[] { 'a', 'ı', 'o', 'u' };
            var inceUnluHarfler = new[] { 'e', 'i', 'ö', 'ü' };

            foreach (char harf in kelime)
            {
                if (Array.IndexOf(kalinUnluHarfler, harf) != -1)
                {
                    return kelime.IndexOfAny(inceUnluHarfler) == -1; 
                }
                else if (Array.IndexOf(inceUnluHarfler, harf) != -1)
                {
                    return kelime.IndexOfAny(kalinUnluHarfler) == -1; 
                }
            }

            return true; 
        }



    }

}
