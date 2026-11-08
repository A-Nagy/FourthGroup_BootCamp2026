import 'package:flutter/material.dart';

class Griditemwidget extends StatelessWidget {
  String Imagepath,itemName;
    Griditemwidget({required this.Imagepath,required this.itemName});

  @override
  Widget build(BuildContext context) {
    return   Expanded(
        flex: 1,
        child:Stack(
          children: [
            Image.asset(Imagepath),
            Text(itemName),
          ],
        )
    );
  }
}
