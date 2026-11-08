import 'package:flutter/material.dart';

class DisplayWaysPage extends StatelessWidget {
  DisplayWaysPage({super.key});
final List<String> items=
List<String>.generate(10, (index)=> 'Item ${index + 1 }');
  @override
  Widget build(BuildContext context) {
    return  Scaffold(
      appBar:AppBar(
        title: const Text('Ways To Display Data', style: TextStyle(color: Colors.white),),
        backgroundColor: Colors.black,
      ) ,
      //GridView // list view 2
      body:
      ListView.builder(
          itemCount  :items.length ,
          itemBuilder:(context , index){
            return Container(
              padding: const EdgeInsets.symmetric(
                vertical:5,
                horizontal:10),
              child: ListTile(
                leading: const Icon(
                    Icons.label_important,
                    color: Colors.blueAccent),
                title: Text(items[index]),
                subtitle:Text(items[index]) ,
                trailing: Icon(Icons.video_label),
                shape:OutlineInputBorder(
                    borderRadius:BorderRadius.circular(20))));})

    /*  GridView.count(
          mainAxisSpacing : 10,
          crossAxisSpacing: 15,
          crossAxisCount  : 2,
          children:List.generate(
              20,
              (index){
                return Card(
                  elevation:15 ,
                  color:Colors.blueAccent ,
                  child:Center(
                    child: Column(
                      children: [
                        Icon(
                          Icons.apple_rounded,
                          color: Colors.amber,
                          size: 60
                        ),
                        Text(
                          'Item ${index+1}',
                          style: TextStyle(
                            fontSize: 40,
                            fontWeight: FontWeight.bold,
                            color: Colors.grey
                          ),
                        )
                      ],
                    ),
                  ) ,
                );
              }),
      ) */,
    );
  }
}
