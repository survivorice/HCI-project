# 语音自主定位方法——开题报告
----
组长：张啸 516030910467   
组员：王力帆 516030910438    汤志彪 516030910435


## 应用背景
        定位是智能交互系统中非常重要的技术环节。传统的定位技术基本都是通过各种传感（红外、蓝牙、视觉、超声波等）技术对目标对象进行跟踪定位。近年来出现了利用SLAM等技术进行对象自主定位的方法。本项目希望通过用语音播报的方式进行对象的粗定位，缩小SLAM搜索空间提高精确定位效率。


## 用户分析
    ？？？
        SLAM

## 设计方案
```flow
st=>start: 开始
e=>end: 返回新的三维地图
input1=>inputoutput: 输入音频
op1=>operation: 接收并辨认用户音频
cond1=>condition: 可辨认？
op2=>operation: 分析音频
cond2=>condition: 可以直接得出地点？
op3=>operation: 返回可选地点
cond3=>condition: 选择地点？
output1=>inputoutput: 返回新得出的地图

st->input1->op1->cond1
cond1(yes)->op2
cond1(no)->op1
op2->cond2
cond2(yes)->output1
cond2(no)->op3->cond3
cond3(yes)->output1
cond3(no)->op1
output1->e

```


## 创新点
？？？


## 技术方案与测试

### 语音识别
        初步考虑在Unity 3D利用百度语音识别进行第一次识别，返回结果为一段string，准确率？？？
### 语音分析
        对上一步返回的string进行分析，提取keyword，对比预设的keyword，如果hit，直接在三维地图上显示（可能非用户期望但仍然hit），如果miss，则产生几种可能的地点结果，返回给用户以供选择
### 






