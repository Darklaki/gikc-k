import pyglet, math, random

WINDOW_WIDTH = 950
WINDOW_HEIGHT = 950
random.seed()

window = pyglet.window.Window(
    width=WINDOW_WIDTH, 
    height=WINDOW_HEIGHT, 
    caption="Drzewo fraktalne"
)
# For drawing all shapes at once
batch = pyglet.graphics.Batch()

# Set window background to white
background = pyglet.shapes.Rectangle(
    x=0,
    y=0,
    width=WINDOW_WIDTH,
    height=WINDOW_HEIGHT,
    color=(255,255,255),
    batch=batch
)

# without storing lines in the array, lines don't show (perhaps they are garbage collected?)
lines=[]


apples=[]

TREE_DEPTH = 13
# draw tree recursively
def draw_tree(x1, y1, angle, depth):
    branch_angle = 20 
    starting_length = 12.5 * random.random()
    if depth > 0:
        # determine ending point for current and ending point for the next call
        x2 = x1 + int(math.cos(math.radians(angle)) * depth * starting_length)
        y2 = y1 + int(math.sin(math.radians(angle)) * depth * starting_length)
        # decide color of branch (green for leaves)
        color=(69, 35, 17)
        if depth != TREE_DEPTH: 
            if TREE_DEPTH * 0.4 > depth: color=(120, 63, 32)
            if TREE_DEPTH * 0.25 > depth: color=(158, 88, 52)
            if depth == 1: color=(55, 156, 37)
        # make leaves bigger
        BRANCH_WIDTH_FACTOR = 0.9
        if depth == 1:
            BRANCH_WIDTH_FACTOR = 4
        # draw a line
        line = pyglet.shapes.Line(
            x=x1,
            y=y1,
            x2=x2,
            y2=y2,
            color=color,
            batch=batch,
            width=(BRANCH_WIDTH_FACTOR*depth)
        )
        lines.append(line)
        # add apples randomly
        if depth == 1 and random.random() >= 0.95:
            APPLE_RADIUS=7
            apple = pyglet.shapes.Circle(
                x=x2 + APPLE_RADIUS/2,
                y=y2 + APPLE_RADIUS/2,
                color=(255, 8, 0),
                radius=APPLE_RADIUS,
                batch=batch
            )
            apples.append(apple)
        draw_tree(x2, y2, angle - branch_angle * random.random(), depth - 1)
        draw_tree(x2, y2, angle + branch_angle * random.random(), depth - 1)


draw_tree(WINDOW_WIDTH / 2, 30, 90, TREE_DEPTH)

@window.event
def on_draw():
    window.clear()
    batch.draw()

pyglet.app.run()
