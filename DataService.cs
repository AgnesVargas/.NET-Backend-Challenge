using TodoApi;
namespace TudoApi
{
    public class DataService
    {
        public List<WeatherForecast> Data { get; set; } = new List<WeatherForecast>();
        public void Add()
        {
            Data.Add(new WeatherForecast()
            {
                Id = 1234,
                fullName = "Juliana Kolmar",
                email = "julianakolmar@gmail.com",
                emailConfirmation = "julianakolmar@gmail.com",
                cpf = "69178399393",
                cellphone = "51984267205",
                dayOfBirth = DateTime.FromOADate(19 - 12 - 2002),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "90035191",
                address = "Av. Osvaldo Aranha",
                number = 720
                
            });
            Data.Add(new WeatherForecast()
            {
                Id = 8,
                fullName = "Agnes Vargas",
                email = "agnesdevargas13@gmail.com",
                emailConfirmation = "agnesdevargas13@gmail.com",
                cpf = "12309834522",
                cellphone = "51998563795",
                dayOfBirth = DateTime.FromOADate(13 - 04 - 2004),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "94828640",
                address = "Saldanha da Gama",
                number = 123
            });

            Data.Add(new WeatherForecast()
            {
                Id = 7,
                fullName = "Keulin Araujo",
                email = "keulinaraujo12@gmail.com",
                emailConfirmation = "keulinaraujo12@gmail.com",
                cpf = "98765423411",
                cellphone = "51984267205",
                dayOfBirth = DateTime.FromOADate(19 - 12 - 2002),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "94828600",
                address = "integaçao",
                number = 120
            });

            Data.Add(new WeatherForecast()
            {
                Id = 6,
                fullName = "Debora Moreira",
                email = "deboramoreira11@gmail.com",
                emailConfirmation = "deboramoreira11@gmail.com",
                cpf = "13579086411",
                cellphone = "51987439278",
                dayOfBirth = DateTime.FromOADate(04 - 08 - 2003),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "94828630",
                address = "Fagundes Varela",
                number = 47
            });

            Data.Add(new WeatherForecast()
            {
                Id = 6,
                fullName = "Susana Araujo",
                email = "susanadesouza10@gmail.com",
                emailConfirmation = "susanadesouza10@gmail.com",
                cpf = "09812356700",
                cellphone = "51985453278",
                dayOfBirth = DateTime.FromOADate(25 - 05 - 1974),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Tapis",
                postalCode = "94828670",
                address = "rio grande",
                number = 49
            });
            Data.Add(new WeatherForecast()
            {
                Id = 5,
                fullName = "Andrey Dias",
                email = "andreyddsantos09@gmail.com",
                emailConfirmation = "andreyddsantos09@gmail.com",
                cpf = "45673809811",
                cellphone = "51912309865",
                dayOfBirth = DateTime.FromOADate(29 - 07 - 2003),
                emailSms = true,
                whatsapp = true,
                country = "Brasil",
                city = "Porto Alegre",
                postalCode = "94828540",
                address = "povo unido",
                number = 255
            });
        }
    }
}