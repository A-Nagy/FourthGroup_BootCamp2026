
import 'dart:convert';

import 'package:fourth_group_mobile1/App1/data/connection.dart';
import 'package:http/http.dart' as http ;
class ProductsService
{
  Future<List<dynamic>> getproducts() async
  {
    final url = Uri.parse(ConnectionString.Products);

    final response =await http.get(url);

    if(response.statusCode == 200 )
    {
      final Map<String,dynamic> data =
          jsonDecode(response.body);

      final List<dynamic> products =
          data['products']as List<dynamic> ;

      return products ;
    }
    else
    {
      throw Exception('Failed to load Data ${response.statusCode} ');
    }
  }
}