import 'package:flutter/material.dart';

class StateFullExamplePage extends StatefulWidget {
  const StateFullExamplePage({super.key});

  @override
  State<StateFullExamplePage> createState() => _StateFullExamplePageState();
}

class _StateFullExamplePageState extends State<StateFullExamplePage> {
  int counter = 1 ;
  bool _isChecked = false;
  bool _isSwitch  = true ;

  String? _Selectvalue ;
  void incrementCounter()
  {
    setState(() {
      counter++;
    });

  }
  void decrementCounter()
  {
    setState(() {
      counter--;
    });

  }
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Counter'),
        backgroundColor: Colors.blue),
      body:Center(
        child:Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Text('Counter Value :',
            style: TextStyle(
              fontSize: 24,
              fontWeight: FontWeight.bold)),
          Text('$counter',
              style: TextStyle(
                  fontSize: 26,
                  fontWeight: FontWeight.bold)),
          Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              ElevatedButton(onPressed:incrementCounter, child: Text('+')),
              const SizedBox(height: 20),
              ElevatedButton(onPressed:decrementCounter, child: Text('-'))
            ],
          ),
          const SizedBox(height: 10),
          Padding(
           padding: EdgeInsets.all(15.0),
           child:Form(
               child:Column(
                   children: [
                     TextFormField(
                       decoration:InputDecoration(
                           labelText: "User Name "
                       ),
                       validator: (value){
                         if(value==null || value.isEmpty)
                         {return "Please Enter Your UserName";}
                         return null ;
                          },
                       ),
                     const  SizedBox(height: 10),
                     TextFormField(
                       decoration:InputDecoration(
                           labelText: "Password"
                       ),
                       validator: (value){
                         if(value==null || value.isEmpty)
                         {return "Please Enter Your Password";}
                         return null ;
                       },
                     ),
                     const  SizedBox(height: 10),
                     Mytextfield("Salary"),
                     const  SizedBox(height: 10),
                     Center(
                       child:Column(
                         children: [
                           DropdownButton<String>(
                               hint:const Text("Select Option"),
                               value: _Selectvalue,
                               items: <String>['Option1','Option2','Option3']
                                   .map<DropdownMenuItem<String>>((String value)
                               {
                                 return DropdownMenuItem(
                                     value:value,
                                     child:Text(value));
                               }).toList(),
                               onChanged: (String? name)
                               {
                                 setState(() {
                                   _Selectvalue=name;
                                 });

                               }
                           ),
                           Checkbox(
                               value: _isChecked,
                               onChanged: (value)
                               {
                                 setState(() {
                                   _isChecked=value!;
                                 });
                               }
                           ),
                           const SizedBox(height: 10),
                           Switch(
                               value: _isSwitch,
                               onChanged:  (value)
                               {
                                 setState(() {
                                   _isSwitch = value;
                                 });
                               })
                         ],
                       ),

                     ),

           ])) ,
         )
        ],
      ),
      )
    );
  }

  Widget Mytextfield(String name)
  {
    return  TextFormField(
      decoration:InputDecoration(
          labelText: "$name",
          labelStyle: TextStyle(
            fontSize: 22,
            color: Colors.blueAccent
          ),
          enabledBorder: OutlineInputBorder(
            borderRadius: BorderRadius.all(Radius.circular(20)),
            borderSide: BorderSide(
              color: Colors.blue,
              width: 2)
          )
      ),
      validator: (value){
        if(value==null || value.isEmpty)
        {return "Please Enter Your $name";}
        return null ;
      },
    );
  }

}
