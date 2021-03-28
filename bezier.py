import math
from PIL import Image
from PIL import ImageDraw

def binomial_coefficient(n, k):
    if k == 1: return n

    n_factorial = 1
    for x in range(1, n):
        n_factorial += n_factorial * x

    k_factorial = 1
    for x in range(1, k):
        k_factorial += k_factorial * x

    nk_factorial = 1
    for x in range(1, n - k):
        nk_factorial += nk_factorial * x

    return n_factorial/(k_factorial*nk_factorial)

def bernstein(n, i, t):
    return binomial_coefficient(n, i) * math.pow(t, i) * math.pow(1 - t, n - i)

def bezier_curve(points, steps):
    n = len(points) - 1
    result = []

    # calculate curve point for t
    def point(t):
        x = 0
        y = 0
        for i in range(0, n + 1):
            x += points[i][0] * bernstein(n,i,t)
            y += points[i][1] * bernstein(n,i,t)
        return (x, y)

    # steps for t from 0 to 1
    for x in range(0, steps+1):
        t = x * (1.0/steps)
        result.append( point(t) )
    
    return result

img_size = 500
img = Image.new("RGB", (img_size, img_size))
draw = ImageDraw.Draw(img)

draw.rectangle([0,0,img_size, img_size], fill="#fff")

# Ł

el = [
    bezier_curve([(50, 90),(50,150)], 100),
    bezier_curve([(50,150),(10,170)], 100),
    bezier_curve([(10,170),(17,168),(10,200)], 100),
    bezier_curve([(10,200),(50,180)], 100),
    bezier_curve([(50,180),(50,270)], 100),
    bezier_curve([(50,270),(170,270)], 100),
    bezier_curve([(170,270),(165,245),(170,240)], 100),
    bezier_curve([(170,240), (95, 240)], 100),
    bezier_curve([(95, 240), (95, 177)], 100),
    bezier_curve([(95, 177), (130, 164)], 100),
    bezier_curve([(132, 164), (125, 137),(132, 135)], 100),
    bezier_curve([(132, 135), (95, 147)], 100),
    bezier_curve([(95, 147), (95, 90)], 100),
    bezier_curve([(95, 90), (50, 90)], 100),
]

for x in el:
    draw.line(x, fill="#000", width=2)

# S
s = [
    bezier_curve([(350, 90),(350,125)], 100),
    bezier_curve([(350, 125),(270,105),(270,170)], 100),
    bezier_curve([(270,170),(270,190),(300,170),(340,200)], 100),
    bezier_curve([(340,200),(360,235),(340,260)], 100),
    bezier_curve([(340,260),(330,280),(260,300),(220,270)], 100),
    bezier_curve([(220,270),(220,240)], 100),
    bezier_curve([(220,240),(260,270),(310,260),(310,240)], 100),
    bezier_curve([(310,240),(320,210),(270,210)], 100),
    bezier_curve([(270,210),(230,200),(240,150)], 100),
    bezier_curve([(240,150),(240,115),(270,90)], 100),
    bezier_curve([(270,90),(315, 70),(350, 90)], 100),
]
for x in s:
    draw.line(x, fill="#000", width=2)
    
# Szlaczki na i na dole górze
sz = []
curves_x = 0
top_height = 15
bottom_height_top = 335
bottom_height_bottom = 350
for i in range(10):
    top_y_moment_1 = top_y_moment_2 = bottom_y_moment_1 = bottom_y_moment_2 = 0
    if i % 2 == 0:
        top_y_moment_1 += top_height
        bottom_y_moment_1 = bottom_height_top
        bottom_y_moment_2 = bottom_height_bottom
    else:
        top_y_moment_2 = top_height
        bottom_y_moment_1 = bottom_height_bottom
        bottom_y_moment_2 = bottom_height_top

    sz.append(bezier_curve([(curves_x, top_y_moment_1),(curves_x + 40, top_y_moment_2)], 100))
    sz.append(bezier_curve([(curves_x, top_y_moment_2),(curves_x + 40, top_y_moment_1)], 100))
    sz.append(bezier_curve([(curves_x, bottom_y_moment_1),(curves_x + 40, bottom_y_moment_2)], 100))
    sz.append(bezier_curve([(curves_x, bottom_y_moment_2),(curves_x + 40, bottom_y_moment_1)], 100))
    curves_x += 40
for x in sz:
    draw.line(x, fill="#000", width=2)

# Liść
lisc = [
    bezier_curve([(20, 70),(20, 45),(60, 50)], 100),
    bezier_curve([(20, 70),(35, 90),(60, 50)], 100),
    bezier_curve([(20, 70),(10, 80)], 100),
    bezier_curve([(27, 66),(34, 60),(47, 56)], 100),
]
for x in lisc:
    draw.line(x, fill="#000", width=2)

img.show()