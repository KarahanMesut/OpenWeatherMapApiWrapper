# OpenWeatherMapApiWrapper

OpenWeatherMapApiWrapper, çeşitli şehirler için hava durumu verilerini alıp sunan basit bir .NET arka uç servisidir. Bu proje, harici API'lerle nasıl etkileşime girileceğini ve verilerin .NET ortamında nasıl işleneceğini göstermek için tasarlanmıştır.

OpenWeatherMapApiWrapper is a simple .NET backend service that integrates with the OpenWeatherMap API to retrieve and serve weather data for various cities. This project is designed to demonstrate how to interact with external APIs and process data in a .NET environment.

## Özellikler / Features

- OpenWeatherMap API'sinden hava durumu verilerini alıp gösterme.
- Şehre göre hava durumu verilerini filtreleme.
- RESTful API uç noktaları.

- Fetch and display weather data from OpenWeatherMap API.
- Filter weather data by city.
- RESTful API endpoints.

## Ön Koşullar / Prerequisites

Başlamadan önce, aşağıdaki gereksinimlerin karşılandığından emin olun:
- .NET 6.0 SDK veya daha sonraki bir sürüm
- Visual Studio 2022 veya .NET geliştirmeyi destekleyen herhangi bir tercih edilen IDE

Before you begin, ensure you have met the following requirements:
- .NET 6.0 SDK or later
- Visual Studio 2022 or any preferred IDE that supports .NET development

## OpenWeatherMapApiWrapper Kurulumu / Installing OpenWeatherMapApiWrapper

WeatherApiService'i yüklemek için şu adımları izleyin:

1. Depoyu klonlayın:

git clone https://github.com/KarahanMesut/OpenWeatherMapApiWrapper.git

2. Proje dizinine gidin:
cd OpenWeatherMapApiWrapper

3. .NET paketlerini geri yükleyin:

dotnet restore

To install WeatherApiService, follow these steps:

1. Clone the repository:
git clone https://github.com/KarahanMesut/OpenWeatherMapApiWrapper.git

2. Navigate to the project directory:
cd OpenWeatherMapApiWrapper

3. Restore the .NET packages:

dotnet restore


## OpenWeatherMapApiWrapper Kullanımı / Using OpenWeatherMapApiWrapper


OpenWeatherMapApiWrapper'i kullanmak için şu adımları izleyin:

1. Projeyi derleyin:

dotnet build

2. Projeyi çalıştırın:

dotnet run

3. API'ye localhost:5000/swagger üzerinden erişin ve Swagger UI aracılığıyla API uç noktalarını test edin.



To use OpenWeatherMapApiWrapper, follow these steps:

1. Build the project:

dotnet build

2. Run the project:

dotnet run

3. Access the API through localhost:5000/swagger to view the Swagger UI and test API endpoints.


## OpenWeatherMapApiWrapper'e Katkıda Bulunma / Contributing to OpenWeatherMapApiWrapper

OpenWeatherMapApiWrapper'e katkıda bulunmak için şu adımları izleyin:

1. Bu depoyu çatallayın (fork).
2. Bir dal oluşturun: git checkout -b <branch_name>.
3. Değişikliklerinizi yapın ve işleyin (commit): git commit -m '<commit_message>'
4. Orijinal dala itin (push): git push origin <project_name>/<location>
5. Çekme isteği oluşturun (pull request).


To contribute to OpenWeatherMapApiWrapper, follow these steps:

1. Fork this repository.
2. Create a branch: git checkout -b <branch_name>.
3. Make your changes and commit them: git commit -m '<commit_message>'
4. Push to the original branch: git push origin <project_name>/<location>
5. Create the pull request.




İletişim / Contact
Benimle iletişime geçmek isterseniz, <rainsguard@gmail.com> adresinden ulaşabilirsiniz.

If you want to contact me, you can reach me at <<rainsguard@gmail.com>.

Lisans / License
Bu proje şu lisansı kullanmaktadır: MIT.

This project uses the following license: MIT.


