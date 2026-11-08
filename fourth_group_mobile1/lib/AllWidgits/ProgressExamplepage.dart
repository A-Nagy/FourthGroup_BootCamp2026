import 'dart:async';

import 'package:flutter/material.dart';

class ProgressBar extends StatefulWidget {
  const ProgressBar({super.key});

  @override
  State<ProgressBar> createState() => _ProgressBarState();
}

class _ProgressBarState extends State<ProgressBar> {
  double progressValue = 0.0 ;
  Timer? timer;

  @override
  void initState() {
    super.initState();
    timer = Timer.periodic(
        const Duration(milliseconds: 300), (t){
       setState(() {
         progressValue +=0.1 ;
         if(progressValue>1)
         {
           progressValue = 0.0;
         }
       });
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title:const Text('Progress Examples'),
        foregroundColor: Colors.white,
        backgroundColor: Colors.black),
      body: Padding(
          padding: const EdgeInsets.all(20),
          child: SingleChildScrollView(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
               //1-Circular Progress Indicator
               const Center(
                child:Text(
                   '1-Circular Progress Indicator',
                   style: const TextStyle(
                     fontWeight: FontWeight.bold,
                     fontSize: 20),
                 )),
               const SizedBox(height: 10),
               const Center(
                 child: CircularProgressIndicator()),
               const SizedBox(height: 10),


                //2-Circular Progress Indicator (Determiante)
                const Center(
                    child:Text(
                      '2-Circular Progress Indicator (Determiante)',
                      style: const TextStyle(
                          fontWeight: FontWeight.bold,
                          fontSize: 16),
                    )),
                const SizedBox(height: 10),
                Center(
                    child: CircularProgressIndicator(
                      value: progressValue,
                      strokeWidth: 8,
                      backgroundColor: Colors.grey.shade300,
                    )),
                const SizedBox(height: 10),
                Center(
                    child:Text(
                      '${(progressValue * 100).toStringAsFixed(0)} %',
                      style: const TextStyle(
                          fontWeight: FontWeight.bold,
                          fontSize: 20),
                    )),
                const SizedBox(height: 10),

                //3-Linear Progress Indicator
                const Center(
                    child:Text(
                      '3-Linear Progress Indicator',
                      style: const TextStyle(
                          fontWeight: FontWeight.bold,
                          fontSize: 20),
                    )),
                const SizedBox(height: 10),
                const Center(
                    child: LinearProgressIndicator()),
                const SizedBox(height: 10),

                //4-Linear Progress Indicator (Determiante)
                const Center(
                    child:Text(
                      '4-Linear Progress Indicator (Determiante)',
                      style: const TextStyle(
                          fontWeight: FontWeight.bold,
                          fontSize: 16),
                    )),
                const SizedBox(height: 10),
                Center(
                    child: LinearProgressIndicator(
                      value: progressValue,
                      minHeight: 8,
                      backgroundColor: Colors.grey.shade300,
                    )),
                const SizedBox(height: 10),
                Center(
                    child:Text(
                      '${(progressValue * 100).toStringAsFixed(0)} %',
                      style: const TextStyle(
                          fontWeight: FontWeight.bold,
                          fontSize: 20),
                    )),
                const SizedBox(height: 10),

                // 5) LinearProgressIndicator داخل Card (ستايل جاهز)
                const Text(
                  '5. Progress داخل Card (تصميم شائع في الداشبورد)',
                  style: const TextStyle(fontWeight: FontWeight.bold),
                ),
                const SizedBox(height: 10),
                Card(
                  elevation: 2,
                  child: Padding(
                    padding: const EdgeInsets.all(16.0),
                    child: Row(
                      children: [
                        Expanded(
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              const Text('رفع الملف...'),
                              const SizedBox(height: 8),
                              LinearProgressIndicator(
                                value: progressValue,
                                minHeight: 8,
                                backgroundColor: Colors.grey.shade300,
                              ),
                              const SizedBox(height: 8),
                              Text(
                                '${(progressValue * 100).toStringAsFixed(0)}%',
                                style: const TextStyle(fontSize: 12),
                              ),
                            ],
                          ),
                        ),
                        const SizedBox(width: 12),
                        const Icon(Icons.upload_file),
                      ],
                    ),
                  ),
                ),
                const SizedBox(height: 30),

                // 6) CircularProgressIndicator صغير كأيقونة حالة
                const Text(
                  '6. أيقونة حالة تحميل صغيرة (مثلاً جنب زر)',
                  style: const TextStyle(fontWeight: FontWeight.bold),
                ),
                const SizedBox(height: 10),
                Row(
                  children: [
                    ElevatedButton(
                      onPressed: () {},
                      child: const Text('حفظ'),
                    ),
                    const SizedBox(width: 16),
                    const SizedBox(
                      height: 20,
                      width: 20,
                      child: const CircularProgressIndicator(strokeWidth: 3),
                    ),
                    const SizedBox(width: 8),
                    const Text('جاري الحفظ...'),
                  ],
                ),

                const SizedBox(height: 50),
              ],
            ),
          ),
      ),
    );
  }
}
