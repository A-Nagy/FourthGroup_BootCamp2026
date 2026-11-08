import 'package:flutter/material.dart';
import 'package:fourth_group_mobile1/Start/GridItemWidget.dart';
 import 'package:fourth_group_mobile1/Start/TitleWidget.dart';

class HomeScreen extends StatelessWidget
{
  const HomeScreen({super.key});
  
  static const String routeName='HomeScreen';
  
  @override
  Widget build(BuildContext context) {
    // TODO: implement build
   return Scaffold(
     backgroundColor: Color(0xffcfd5d2),
     appBar:AppBar(
       title: Text('Home'),
       leading: Icon(Icons.arrow_back),
       centerTitle: true,
       backgroundColor: Color(0xff0f237c),
       foregroundColor: Colors.white,

     ) ,
     body:SingleChildScrollView(
       child: Column(
         children: [
           ElevatedButton(
               onPressed: ()
               {
                 Navigator.pop(context);
               }, child: Text('Back')),
           Row(
             children: [
               Titlewidget(
                   TitleName: 'خضروات'
               ),

               SizedBox(width: 10),
       
               Titlewidget(
                   TitleName: 'فاكهة'
               )
       
             ],
           ),
           SizedBox(height: 10),
           Row(
             children: [
             Griditemwidget(Imagepath: 'assets/images/f1.jpg', itemName: 'ItemName'),
             SizedBox(width: 10),
             Griditemwidget(Imagepath: 'assets/images/f2.jpg', itemName: 'ItemName2')
             ],
           )
         ],
       ),
     )
       

   );
  }

}