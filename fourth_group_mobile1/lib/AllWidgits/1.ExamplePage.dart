import 'package:flutter/material.dart';

class ExamplePage2 extends StatelessWidget {
  const ExamplePage2({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Second'),
        backgroundColor: Colors.blue),
      body: SingleChildScrollView(
        child: Column(
          children: [
            ElevatedButton(onPressed: (){}, child: Icon(Icons.add_box_rounded)),
            SizedBox(height: 10),
            TextButton(onPressed:  (){}, child: Text('Text Button')),
            SizedBox(height: 10),
            OutlinedButton(onPressed:  (){}, child: Text('OutLine Button'))
            ,SizedBox(height: 10),
            ElevatedButton(
                onPressed: (){},
                child:SizedBox(
              width: 100,
              child: Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Icon(Icons.add_box_rounded),
                  SizedBox(width: 10),
                  Text('Add')
                ],
              ),
            )),
            SizedBox(height: 10),
            InkWell(
              onTap: (){
                print('Ink well tapped');
              },
              borderRadius: BorderRadius.circular(8),
              child: Container(
                padding: EdgeInsets.all(15),
                decoration: BoxDecoration(
                  color: Colors.amber,
                  borderRadius: BorderRadius.circular(8)
                ),
              ),

              
            ),
            SizedBox(height: 10),
           FloatingActionButton(onPressed:  (){}, child: Icon(Icons.add))
            
          ],
        ),
      ),
      floatingActionButton: FloatingActionButton(onPressed:  (){}, child: Icon(Icons.add),),
    );
  }
}
