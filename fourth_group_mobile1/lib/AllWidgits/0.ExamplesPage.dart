import 'package:flutter/material.dart';

class Examplepage extends StatelessWidget {
  const Examplepage({super.key});

  @override
  Widget build(BuildContext context) {
    return Directionality(
        textDirection: TextDirection.ltr
        , child: Scaffold(
      drawer: const Drawer(),
      appBar: AppBar(
        title:const Text(
            'First',
          style: TextStyle(
            fontSize: 28,
            fontWeight: FontWeight.bold,
           // color: Colors.white
          ),
        ),
        foregroundColor: Colors.white,
        centerTitle: true,
        backgroundColor:Colors.amber,
      ),
      body  : Column(
        children: [
          Container(
            padding:EdgeInsets.all(50),
            margin:EdgeInsets.symmetric(
                horizontal:25 ,
                vertical:25 ) ,
            decoration:BoxDecoration(
              borderRadius: BorderRadius.circular(50),
              color: Colors.blue,
              gradient: SweepGradient(
                  colors: [
                    Colors.blue,
                    Colors.red,
                    Colors.green
                  ]),
              border:Border.all(
                  width: 5,color:
              Colors.black
              ) ,
              image:DecorationImage(
                  image:AssetImage('assets/images/f3.jpg'),
                  fit: BoxFit.fill,
                  opacity: 0.2
              ) ,
              boxShadow:const [
                BoxShadow(
                    color: Colors.red,
                    blurRadius: 10.0,
                    offset: Offset(-7,-7)),
                BoxShadow(
                    color: Colors.red,
                    blurRadius: 10.0,
                    offset: Offset(7,7)),
              ] ,

            ),
            child: Text(
                'Flutter Course',
                style: TextStyle(
                  fontSize: 40,
                  fontWeight: FontWeight.bold,
                  color: Colors.black,
                )),
            //color: Colors.blue,
          ),
          Container(
            child:Image.network('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS-SmX4r9PqcGnGPwacyYSQYLojk85juniI4A&s',
              width: 200,
              height: 200,)
            ,
          )
        ],
      ),
      floatingActionButton:Container(
        color: Colors.red,
        height:50,
        width: 50,
        child:Center(child: Text('Press')) ,
      ) ,
      bottomNavigationBar :Container(
        color: Colors.amber,
        height: 80,
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            Icon(Icons.home,size:60 ,color: Color(0xff8f8c8c)),
            Icon(Icons.person,size:60 ,color: Color(0xff8f8c8c)),
            Icon(Icons.exit_to_app,size:60 ,color: Color(0xff8f8c8c))
          ],
        ),
      ),
    ));
  }
}
