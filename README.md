# Dinamik Kare Bilgi Penceresi Projesi

Bu proje, bir Windows Forms uygulaması içinde rastgele yerleştirilmiş kareleri içermekte ve fare imleci bu karelerin üzerine geldiğinde ilgili bilgileri göstermektedir.

## Proje Çalıştırma Adımları

1. Bu projeyi bilgisayarınıza klonlayın veya ZIP olarak indirin.

    ```bash
    git clone https://github.com/asimbugra/RandomRectangleTooltip.git
    ```

    veya

    [Buradan ZIP olarak indirin](https://github.com/asimbugra/RandomRectangleTooltip/archive/main.zip)

2. Visual Studio veya başka bir C# IDE kullanarak projeyi açın.

3. Projeyi oluşturan ana form olan `Form1.cs` dosyasını açın.

4. `button1_Click` metodunu inceleyin ve isterseniz kareleri oluşturan döngüyü değiştirin. Varsayılan olarak 10 adet kare oluşturulmaktadır.

5. Projeyi derleyin ve çalıştırın.

## Kullanım

- Uygulama çalıştığında, "Kareler Oluştur" butonuna tıklayarak rastgele yerleştirilmiş kareleri ekleyebilirsiniz.

- Fare imleci bir karenin üzerine geldiğinde, karenin konumu hakkında bir bilgi penceresi görüntülenir.

- Karelerin üzerinden ayrıldığınızda bilgi penceresi gizlenir.

## Ek Bilgiler

- Bu proje, Windows Forms uygulamalarının temel özelliklerini kullanarak oluşturulmuştur.

- Karelerin özellikleri ve davranışı `CizimYap` ve `pictureBox1_MouseMove` metodlarında tanımlanmıştır.

- Projede kullanılan `ToolTip` sınıfı ile fare imleci karelerin üzerine geldiğinde bilgi gösterimi sağlanır.
