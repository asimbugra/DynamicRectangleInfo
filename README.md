<!DOCTYPE html>
<html>

<head>
    <title>Dynamic Rectangle Tooltip Project</title>
</head>

<body>

    <h1>Dynamic Rectangle Tooltip Project</h1>

    <p>Bu proje, bir Windows Forms uygulaması içinde rastgele yerleştirilmiş kareleri içermekte ve fare imleci bu karelerin üzerine geldiğinde ilgili bilgileri göstermektedir.</p>

    <h2>Proje Çalıştırma Adımları</h2>

    <ol>
        <li>Bu projeyi bilgisayarınıza klonlayın veya ZIP olarak indirin.</li>

        <pre>
            git clone https://github.com/asimbugra/RandomRectangleTooltip.git
        </pre>

        veya

        [Buradan ZIP olarak indirin](https://github.com/asimbugra/RandomRectangleTooltip/archive/main.zip)

        <li>Visual Studio veya başka bir C# IDE kullanarak projeyi açın.</li>

        <li>Projenin ana formu olan <code>Form1.cs</code> dosyasını açın.</li>

        <li><code>button1_Click</code> metodunu inceleyin ve isterseniz kareleri oluşturan döngüyü değiştirin. Varsayılan olarak 10 adet kare oluşturulmaktadır.</li>

        <li>Projenizi derleyin ve çalıştırın.</li>
    </ol>

    <h2>Kullanım</h2>

    <ul>
        <li>Uygulama çalıştığında, "Kareler Oluştur" butonuna tıklayarak rastgele yerleştirilmiş kareleri ekleyebilirsiniz.</li>

        <li>Fare imleci bir karenin üzerine geldiğinde, karenin konumu hakkında bir bilgi penceresi görüntülenir.</li>

        <li>Karelerin üzerinden ayrıldığınızda bilgi penceresi gizlenir.</li>
    </ul>

    <h2>Ek Bilgiler</h2>

    <ul>
        <li>Bu proje, Windows Forms uygulamalarının temel özelliklerini kullanarak oluşturulmuştur.</li>

        <li>Karelerin özellikleri ve davranışı <code>CizimYap</code> ve <code>pictureBox1_MouseMove</code> metodlarında tanımlanmıştır.</li>

        <li>Projede kullanılan <code>ToolTip</code> sınıfı ile fare imleci karelerin üzerine geldiğinde bilgi gösterimi sağlanır.</li>
    </ul>

</body>

</html>
