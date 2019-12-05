# Markdown
---
## Markdown คือ 
    
 Mark down คือ ภาษาคอมพิวเตอร์ ที่มนุษย์สามารถอ่านเข้าใจได้ง่าย
    และด้วยความง่ายนี้มันก็สามารถแปลงกลับมาเป็นภาษาอื่นๆ
    ได้ง่ายด้วยกันเช่น HTML, XHTML และด้วยความง่ายเช่นนี้จึงมีเจ้าอื่นนำไป Customize ให้เป็นของตัวเอง
    เช่น github ก็อาจจะเพิ่มพวก feature 
    เข้าไปเช่น task list, mention และอื่น ๆ 

---

## HTML vs Markdown

    <h1> Hello </h1>| # Hello
    <h2> Hi </h2>   | ## Hi
    <ul>            |
    <li>Apple</li>  |* Apple
    <li>Banana</li> |* Banana
    <li>Orange</li> |* Orange
    </ul>           |

---
@snap[north span-50]
## เริ่มเขียนMarkdown

### การเขียนหัวเรื่อง
@snapend

@snap[east span-50]
# หัวเรื่อง 1
## หัวเรื่อง 2
### หัวเรื่อง 3
#### หัวเรื่อง 4
##### หัวเรื่อง 5
###### หัวเรื่อง 6
@snapend

                   
---
รูปแบบอักษรประกอบไปด้วย

ตัวหนา

**ตัวหนา**

ตัวเอียง

*ตัวเอียง*

ขีดฆ่า

~~ขีดฆ่า~~
---

## ลิสต์(list)

มีทังหมด3แบบประกอบด้วย


1.ลิสต์แบบเรียงลำดับ (Ordered List)


2.ลิสต์แบบไม่เรียงลำดับ (Unordered List)


3.หรือ list ซ้อน list (Nested List)


---
@snap[north span-50]
ลิสต์แบบเรียงลำดับ (Ordered List)
@snapend

@snap[east span-50]
1. สวัสดี
2. ฉัน
3. ชื่อ
4. บุษบา
@snapend

---
@snap[north span-50]
ลิสต์แบบไม่เรียงลำดับ (Unordered List)
@snapend

@snap[east span-50]
* สวัสดี
* สวัสดี
* สวัสดี
@snapend


---
@snap[north span-50]
หรือ list ซ้อน list  (Nested List)
@snapend

@snap[east span-50]
1. สวัสดี
   - ฉันชื่อ
     - บุษบา
       1. ลาล่าล่าล๊า
       2. ลาล่าล่าล๊า
@snapend

---
## การใส่ link ใน Markdown

โค้ต

เเสดงผล

[Links](http://www.google.com)
---
## ใส่รูปภาพใน Markdown 

โค้ต

    ![Google ](https://sv1.picz.in.th/images/2019/12/05/iZyaHz.jpg)

เเสดงผล

![Google ](https://www.google.co.th/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png)
---
@snap[north span-50]
## การใส่ตาราง (Tables)
@snapend



@snap[east span-50]
| หัวเรื่องแรก | หัวเรื่องที่สอง |  หัวเรื่องสาม |
| :-------- | :--------: | ---------: |
|   ซ็าย   |   กึ่งกลาง   |    ขวา   |
|   ซ็าย   |   กึ่งกลาง   |    ขวา   |
@snapend
---
## HTML vs Markdown
---?color=linear-gradient(90deg, white 50%, black 50%)

@snap[west span-40 text-center]

### GraphQL
@fa[quote-left quote-graphql](A query language for your API)
<h1> Hello </h1>
<h2> Hi </h2>
<ul>
  <li>Apple</li>
  <li>Banana</li>
  <li>Orange</li>
</ul>

@snapend

@snap[north-east span-40 text-08]
# Hello
## Hi
* Apple
* Banana
* Orange
@snapend