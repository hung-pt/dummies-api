using Api.Catalog.Dtos;
using Api.Dummies.Infrastructure;
using System.ComponentModel;

namespace Api.Dummies.Routes;

public static class ProductApi {
    internal static RouteGroupBuilder MapProductApi(this RouteGroupBuilder group) {
        group.MapGet("/", ([DefaultValue(1)] int? pageIndex, [DefaultValue(10)] int? pageSize) =>
            Seed.Products.Skip((pageIndex - 1) * pageSize ?? 1).Take(pageSize ?? 10));
        group.MapGet("/{productCode}", (string productCode) =>
            Seed.Products.FirstOrDefault(e => e.ProductCode == productCode));
        group.MapPost("/", (ProductCreateDto newProduct) => {
            Seed.Products.Add(BasicMapper.Map<Product>(newProduct)!);
            return newProduct;
        });
        group.MapDelete("/{productCode}", (string productCode) =>
            Seed.Products.Remove(Seed.Products.First(e => e.ProductCode == productCode)));

        return group;
    }
}
