
import 'package:flutter/material.dart';
import 'package:fourth_group_mobile1/App1/LoginScreen1.dart';
import 'package:fourth_group_mobile1/App1/Screens/ProductScreen.dart';

void main()
{
  runApp(const  MyApp());
}

class MyApp extends StatelessWidget
{
  const MyApp({super.key});
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple)
      ),
      debugShowCheckedModeBanner: false,
      home: ProductScreen(),

    );

  }

}
