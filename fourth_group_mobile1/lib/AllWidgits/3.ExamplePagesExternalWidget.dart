import 'package:flutter/material.dart';
import 'package:fourth_group_mobile1/Start/HomeScreen.dart';

class ExternalWidgets extends StatelessWidget {
  const ExternalWidgets({super.key});

 void _showDialog(BuildContext context , String title)
 {
   showDialog(
       context: context,
       builder: (context){
        return AlertDialog(
          title:Row(
            children: [
              const Icon(Icons.warning,color: Colors.red,),
              SizedBox(width: 5),
              Text(
                title,
                style: TextStyle(
                    color: Colors.black,
                    fontSize: 24,
                    fontWeight:FontWeight.bold)
              )
            ],
          ) ,
          content: const Text(
              'This Is Alert Dialog',
              style: TextStyle(
                fontSize: 28,
                color: Colors.red
              )),
          actions: [
            TextButton(onPressed: ()=>{
              Navigator.of(context).pop()},
                child: const Text('Ok')),
            TextButton(onPressed: ()=>{
              Navigator.of(context).pop()},
                child: const Text('Cancel'))
          ],
        );
       });

 }


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar:AppBar(
        title: const Text('Examples'),
        centerTitle: true,
        backgroundColor: Colors.black,
        foregroundColor: Colors.white,
      ) ,
      drawer:Drawer(
        child: Column(
          children: [
            const UserAccountsDrawerHeader(
                decoration:BoxDecoration(
                  color: Colors.black
                ) ,
                accountName : Text('Ahmad Nagy',style: TextStyle(fontSize: 22),),
                accountEmail: Text('agmail.com'),
                currentAccountPicture: CircleAvatar(
                  backgroundColor: Colors.white,
                  child: Text(
                    'A',
                    style: TextStyle(
                      fontSize: 26,
                      fontWeight: FontWeight.bold,
                      color: Colors.blue
                    ),
                  ),
                ) ,
            ),
            ListTile(
              leading:const Icon(Icons.home) ,
              title:const Text('Home')   ,
              subtitle:const Text('Go To Home') ,
              trailing:Icon(Icons.arrow_forward) ,
              onTap: (){
                Navigator.pop(context);
                Navigator.push(
                    context,
                    MaterialPageRoute(
                    builder: (context)=>const HomeScreen()));
              },
            ),
            const Divider(),
            ListTile(
              leading:const Icon(Icons.person,color: Colors.greenAccent,) ,
              title:const Text('Profile') ,
              onTap: (){
                Navigator.pop(context);
                Navigator.push(
                    context,
                    MaterialPageRoute(
                        builder: (context)=>const HomeScreen()));
              },
            ),
            const Divider(),
            const Spacer(),
            ListTile(
                  leading:const Icon(Icons.settings,color: Colors.grey,) ,
                  title:const Text('Settings') ,
                  onTap: (){
                    Navigator.pop(context);
                    Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context)=>const HomeScreen()));
                  },
                ),
            ListTile(
                  leading:const Icon(Icons.logout,color: Colors.red) ,
                  title:const Text('Logout') ,
                  onTap: (){
                    Navigator.pop(context);
                    Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context)=>const HomeScreen()));
                  },
                ),
              ],
            )
      ) ,
      endDrawer: Drawer(
          child: Column(
            children: [
              const UserAccountsDrawerHeader(
                decoration:BoxDecoration(
                    color: Colors.black
                ) ,
                accountName : Text('أحمد ناجي ',style: TextStyle(fontSize: 22),),
                accountEmail: Text('حساب شخصي'),
                currentAccountPicture: CircleAvatar(
                  backgroundColor: Colors.white,
                  child: Text(
                    'A',
                    style: TextStyle(
                        fontSize: 26,
                        fontWeight: FontWeight.bold,
                        color: Colors.blue
                    ),
                  ),
                ) ,
              ),
              ListTile(
                leading:const Icon(Icons.home) ,
                title:const Text('الرئيسية')   ,
                subtitle:const Text('اذهب للشاشة الرئيسية') ,
                trailing:Icon(Icons.arrow_forward) ,
                onTap: (){
                  Navigator.pop(context);
                  Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context)=>const HomeScreen()));
                },
              )

            ],
          )
      ),
      backgroundColor:Colors.white ,
      body:Center(
        child: ElevatedButton(
            onPressed: ()=>_showDialog(context,'Alert'),
            child: const Text('Show Dialog')),
      ) ,
    );
  }
}
