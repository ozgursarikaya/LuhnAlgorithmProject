namespace LuhnAlgorithmProject
{
    internal class LuhnAlgorithm
    {
        internal static bool IsValid(string cardNumber)
        {
            int sum = 0;
            bool isSecond = false;

            // Kart numarasını sağdan sola doğru işle
            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int digit = cardNumber[i] - '0';

                // Her ikinci rakamı ikiyle çarp
                if (isSecond)
                {
                    digit *= 2;

                    // Eğer çarpım 9'dan büyükse, rakamları topla (örneğin 12 için: 1 + 2 = 3)
                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                // Toplamı güncelle
                sum += digit;

                // Bir sonraki rakamın ikinci olup olmadığını belirt
                isSecond = !isSecond;
            }

            // Toplamın 10 ile tam bölünüp bölünmediğini kontrol et (mod 10)
            return (sum % 10 == 0);
        }
    }
}
