package com.promact.basiccalculator;

import android.content.DialogInterface;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    private Button btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9,btn10,btnadd,btnminus,btnC,btnequal;
    private TextView result,display;
    private int val1=0,val2,sum=0;
    private boolean add,minus,equal,mul;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btn1= (Button) findViewById(R.id.button_0);
        btn2= (Button) findViewById(R.id.button_1);
        btn3= (Button) findViewById(R.id.button_2);
        btn4= (Button) findViewById(R.id.button_3);
        btn5= (Button) findViewById(R.id.button_4);
        btn6= (Button) findViewById(R.id.button_5);
        btn7= (Button) findViewById(R.id.button_6);
        btn8= (Button) findViewById(R.id.button7);
        btn9= (Button) findViewById(R.id.button8);
        btn10= (Button) findViewById(R.id.button9);
        btnadd= (Button) findViewById(R.id.button_add);
        btnminus= (Button) findViewById(R.id.button_minus);
        btnequal= (Button) findViewById(R.id.button_equal);
        btnC= (Button) findViewById(R.id.button_cut);
        result= (TextView) findViewById(R.id.result);
        display= (TextView) findViewById(R.id.display);

        btn1.setOnClickListener(this);
        btn2.setOnClickListener(this);
        btn3.setOnClickListener(this);
        btn4.setOnClickListener(this);
        btn5.setOnClickListener(this);
        btn6.setOnClickListener(this);
        btn7.setOnClickListener(this);
        btn8.setOnClickListener(this);
        btn9.setOnClickListener(this);
        btn10.setOnClickListener(this);
        btnadd.setOnClickListener(this);
        btnminus.setOnClickListener(this);
        btnC.setOnClickListener(this);
        btnequal.setOnClickListener(this);



    }

    @Override
    public void onClick(View v) {


        switch (v.getId()) {

            case R.id.button_0:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }


                val1=val1*10+Integer.parseInt(btn1.getText().toString());
                display.append(btn1.getText());

                break;
            case R.id.button_1:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn2.getText().toString());
                display.append(btn2.getText());

                break;
            case R.id.button_2:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn3.getText().toString());
                display.append(btn3.getText());

                break;
            case R.id.button_3:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn4.getText().toString());
                display.append(btn4.getText());

                break;
            case R.id.button_4:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn5.getText().toString());
                display.append(btn5.getText());

                break;
            case R.id.button_5:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn6.getText().toString());
                display.append(btn6.getText());

                break;
            case R.id.button_6:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn7.getText().toString());
                display.append(btn7.getText());

                break;
            case R.id.button7:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn8.getText().toString());
                display.append(btn8.getText());

                break;
            case R.id.button8:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn9.getText().toString());
                display.append(btn9.getText());

                break;
            case R.id.button9:
                if(equal==true){
                    display.setText("");
                    result.setText("");
                    equal=false;
                    sum=0;
                }
                val1=val1*10+Integer.parseInt(btn10.getText().toString());
                display.append(btn10.getText());

                break;

            case R.id.button_add:
                if(equal==true) {
                    display.setText("");
                    display.append(result.getText().toString());

                    sum=Integer.parseInt(result.getText().toString());
                    equal=false;
                }
                    display.append(btnadd.getText().toString());
                   sum=sum+val1;
                    val1=0;
                add=true;
                break;
            case R.id.button_cut:
                display.setText("");
                result.setText("");
                sum=0;
                equal=false;

                break;

            case R.id.button_minus:
                if(equal==true) {
                    display.setText("");
                    display.append(result.getText().toString());
                    equal=false;
                }
                if(display.getText().equals(0))
                display.setText("");
                display.append(btnminus.getText());
                if(val1 >sum)
                sum=val1-sum;
                if(sum >val1)
                sum=sum-val1;
                val1=0;
                minus=true;
                break;
            case R.id.button_equal:
                equal=true;
                if(val1!=0) {

                   if (add == true) {
                       sum = sum + val1;
                       add = false;
                   }


                    if (minus == true) {
                        sum = sum - val1;
                        minus = false;
                    }
                }
                if(sum==0)
                    result.setText("");
                else
                result.setText(""+sum);
                val1=0;

                break;

        }

    }
}
