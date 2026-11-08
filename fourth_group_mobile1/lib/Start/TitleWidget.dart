import 'package:flutter/material.dart';

class Titlewidget extends StatelessWidget {
  String TitleName ;
  Titlewidget({required this.TitleName});

  @override
  Widget build(BuildContext context) {
    return  Expanded(
        flex: 2,
        child: Container(
            color: Color(0xff2c50c1),
            child: Text(
              TitleName,
              textAlign: TextAlign.center,
              style: TextStyle(
                  fontSize: 24,
                  fontWeight: FontWeight.bold,
                  color: Colors.white
              ),
            )
        )
    );
  }
}
