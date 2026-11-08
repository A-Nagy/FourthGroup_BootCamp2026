import 'package:flutter/material.dart';
import 'package:fourth_group_mobile1/Start/HomeScreen.dart';

class LoginScreen  extends StatelessWidget {
  const LoginScreen ({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('تسجيل الدخول')
      ),
      body: ElevatedButton(onPressed: ()
      {
        Navigator.of(context).pushNamed(HomeScreen.routeName);
      }, child: Text('Login')),
    );
  }
}
