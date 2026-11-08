import 'package:flutter/material.dart';
import 'package:fourth_group_mobile1/App1/Services/ProductService.dart';

class ProductScreen extends StatefulWidget {
  const ProductScreen({super.key});

  @override
  State<ProductScreen> createState() => _ProductScreenState();
}

class _ProductScreenState extends State<ProductScreen> {

  final ProductsService productsService = ProductsService();

  late Future<List<dynamic>> products;

  @override
  void initState() {
    super.initState();
    products = productsService.getproducts();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Product'),
        backgroundColor: Colors.indigo,
        foregroundColor: Colors.white,
      ),
      body: FutureBuilder<List<dynamic>>(
        future: products,
        builder: (context,snapshot){
          if(snapshot.connectionState == ConnectionState.waiting)
          {
            return Center(
              child: CircularProgressIndicator()
            );

          }
          if(snapshot.hasError)
          {
            return Center(
              child: Padding(
                padding: EdgeInsets.all(16),
                child: Text('Error: ${snapshot.error}'),
              ),
            );

          }
          final productlist = snapshot.data ?? [] ;
          if(productlist.isEmpty)
          {
            return const Center(
              child: Text('No Products'),
            );
          }
          return GridView.builder(
              padding: const EdgeInsets.all(15),
              gridDelegate:
              const SliverGridDelegateWithFixedCrossAxisCount(
                  crossAxisCount: 2  ,
                crossAxisSpacing: 10 ,
                 mainAxisSpacing: 10 ,
                childAspectRatio: 0.75
              ),
              itemCount: productlist.length,
              itemBuilder: (context, index){
                final product= productlist[index];
                return Card(
                  elevation: 5,
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(15),
                  ),
                  child: Column(
                    children: [
                      Expanded(
                          child: ClipRRect(
                            borderRadius: BorderRadius.vertical(
                              top: Radius.circular(15),
                            ),
                            child: Image.network(
                                product['thumbnail']?.toString()??'',
                            width: double.infinity,
                            fit: BoxFit.cover,
                            errorBuilder: (context,error, StackTrace){
                                  return const Center(
                                    child: Icon(Icons.image_not_supported,
                                      size: 50)
                                  );
                            }),
                          )),
                      const SizedBox(height: 10),
                      Padding(
                          padding: const EdgeInsets.symmetric(horizontal:8),
                      child: Text(
                          product['title']?.toString()??'',
                      style: const TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.bold
                      )),

                      ),
                      const SizedBox(height: 10),
                      Padding(
                        padding: const EdgeInsets.symmetric(horizontal:8),
                        child: Text(
                           'Price :  ${product['price']?.toString()??''} SAR',
                            style: const TextStyle(
                                fontSize: 15,
                                fontWeight: FontWeight.bold,
                                color:Colors.grey
                            )),

                      )
                    ],
                  ),
                );
              }
          );
        },
      ),
    );
  }
}
