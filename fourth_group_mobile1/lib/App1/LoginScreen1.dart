import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:fourth_group_mobile1/App1/SignupScreen.dart';
import 'package:fourth_group_mobile1/Start/HomeScreen.dart';
class Loginscreen1 extends StatelessWidget {
  Loginscreen1({super.key});

  TextEditingController usernamecontroller = TextEditingController();
  TextEditingController passwordcontroller = TextEditingController();

  Future<List<dynamic>> loadUsers() async
  {
    String JsonString =
    await rootBundle.loadString('/lib/App1/data/users.json');
    return json.decode(JsonString);
  }
  void login(BuildContext context) async
  {
    final users = await loadUsers();
    String username = usernamecontroller.text;
    String password = passwordcontroller.text;
    bool userfound = users.any(
        (user)=> user['username'] == username && user['password']==password
    );
    if(userfound)
    {
      Navigator.push(context, MaterialPageRoute(builder: (context)=>HomeScreen()));
    }else
    {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
        content: Text('Invalid Data'),
        behavior: SnackBarBehavior.floating,
        duration: Duration(seconds: 3),
          shape: OutlineInputBorder(borderRadius: BorderRadius.circular(20)),
          backgroundColor: Colors.black26,
        )
      );
    }

  }
   
  
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Login '),
        backgroundColor: Colors.indigo,
      ),
      body: Padding(padding: EdgeInsets.all(16,),
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            const SizedBox(height: 50,),
            const Icon(Icons.person, size: 100, color: Colors.indigo),
           
            TextField(
              controller: usernamecontroller,
              decoration: const InputDecoration(
                labelText: 'Username',
                border: const OutlineInputBorder(),
                prefixIcon: const Icon(Icons.person),
              ),
            ),
            const SizedBox(
              height: 20,
            ),
            
            TextField(
              controller: passwordcontroller,
              obscureText: true,
              decoration: const InputDecoration(
                labelText: 'Password',
                border: const OutlineInputBorder(),
                prefixIcon: const Icon(Icons.lock),
              ),
            ),
            const SizedBox(
              height: 20,
            ),

            ElevatedButton(
              onPressed: ()=> login(context),
              child: const Text('Login2'),
            ),
            const SizedBox(
              height: 20,
            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                const Text('Dont have an account?'),
                GestureDetector(


                  child: const Text(
                    ' Sign Up',
                    style: TextStyle(
                        decoration: TextDecoration.underline,
                        color: Colors.blue),
                  ),
                ),


              ],
            ),
            const SizedBox(
              height: 10,
            ),
            const Text('Navigate to Forget Password?'),
            GestureDetector(
              onTap: () {},
              child: const Text(
                'Fofget Password',
                style: TextStyle(
                    decoration: TextDecoration.underline, color: Colors.blue),
              ),
            ),


          ],
        ),
      ),
    );
  }
}