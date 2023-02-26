namespace Api.Dummies.Infrastructure;

internal static class Seed {
    // processed from https://www.mysqltutorial.org/mysql-sample-database.aspx
    internal static List<ProductLine> ProductLines { get; set; } = new(){
        new ProductLine("Cars","Attention car enthusiasts: Make your wildest car ownership dreams come true. Whether you are looking for classic muscle cars, dream sports cars or movie-inspired miniatures, you will find great choices in this category. These replicas feature superb attention to detail and craftsmanship and offer features such as working steering system, opening forward compartment, opening rear trunk with removable spare wheel, 4-wheel independent spring suspension, and so on. The models range in size from 1:10 to 1:24 scale and include numerous limited edition and several out-of-production vehicles. All models include a certificate of authenticity from their manufacturers and come fully assembled and ready for display in the home or office.",null,null),
        new ProductLine("Planes","Unique, diecast airplane and helicopter replicas suitable for collections, as well as home, office or classroom decorations. Models contain stunning details such as official logos and insignias, rotating jet engines and propellers, retractable wheels, and so on. Most come fully assembled and with a certificate of authenticity from their manufacturers.",null,null),
    };
    internal static List<Product> Products { get; set; } = new() {
        new Product("S10_1949","1952 Alpine Renault 1300","Cars","1:10","Classic Metal Creations","Turnable front wheels; steering function; detailed interior; detailed engine; opening hood; opening trunk; opening doors; and detailed chassis.",7305,98.58m,214.30m),
        new Product("S10_4757","1972 Alfa Romeo GTA","Cars","1:10","Motor City Art Classics","Features include: Turnable front wheels; steering function; detailed interior; detailed engine; opening hood; opening trunk; opening doors; and detailed chassis.",3252,85.68m,136.00m),
        new Product("S24_3432","2002 Chevy Corvette","Cars","1:24","Gearbox Collectibles","The operating parts of this limited edition Diecast 2002 Chevy Corvette 50th Anniversary Pace car Limited Edition are particularly delicate due to their precise scale and require special care and attention. Features rotating wheels, poseable streering, opening doors and trunk.",9446,62.11m,107.08m),
        new Product("S24_3856","1956 Porsche 356A Coupe","Cars","1:18","Classic Metal Creations","Features include: Turnable front wheels; steering function; detailed interior; detailed engine; opening hood; opening trunk; opening doors; and detailed chassis.",6600,98.30m,140.43m),
        new Product("S24_4048","1992 Porsche Cayenne Turbo Silver","Cars","1:24","Exoto Designs","This replica features opening doors, superb detail and craftsmanship, working steering system, opening forward compartment, opening rear trunk with removable spare, 4 wheel independent spring suspension as well as factory baked enamel finish.",6582,69.78m,118.28m),

        new Product("S24_4278","1900s Vintage Tri-Plane","Planes","1:24","Unimax Art Galleries","Hand crafted diecast-like metal Triplane is Re-created in about 1:24 scale of antique pioneer airplane. This antique style metal triplane is all hand-assembled with many different parts.",2756,36.23m,72.45m),
        new Product("S700_1691","American Airlines: B767-300","Planes","1:700","Min Lin Diecast","Exact replia with official logos and insignias and retractable wheels",5841,51.15m,91.34m),
        new Product("S700_2466","America West Airlines B757-200","Planes","1:700","Motor City Art Classics","Official logos and insignias. Working steering system. Rotating jet engines",9653,68.80m,99.72m),
    };
}
