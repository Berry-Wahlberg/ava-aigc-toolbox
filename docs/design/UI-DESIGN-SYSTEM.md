# BerryAIGC UI Design System

## Overview

This document provides a comprehensive guide to the BerryAIGC UI design system, including color schemes, typography, spacing, components, and best practices for creating consistent and accessible user interfaces.

## Table of Contents

1. [Design Principles](#design-principles)
2. [Color System](#color-system)
3. [Typography](#typography)
4. [Spacing & Layout](#spacing--layout)
5. [Components](#components)
6. [Animations & Interactions](#animations--interactions)
7. [Responsive Design](#responsive-design)
8. [Accessibility](#accessibility)

---

## Design Principles

### Core Values

- **Consistency**: Maintain visual and functional consistency across all interfaces
- **Clarity**: Ensure information is clear, readable, and understandable
- **Efficiency**: Minimize user effort to complete tasks
- **Accessibility**: Design for users of all abilities
- **Aesthetics**: Create visually appealing and modern interfaces

### Design Philosophy

The design system follows Material Design principles adapted for WPF, focusing on:

- **Purposeful Motion**: Animations should serve a functional purpose
- **Visual Hierarchy**: Use size, color, and spacing to guide attention
- **Responsive Layouts**: Adapt to different screen sizes and orientations
- **Touch-Friendly**: Ensure interactive elements are appropriately sized

---

## Color System

### Primary Colors

| Color | Light Mode | Dark Mode | Usage |
|--------|-----------|-----------|--------|
| Primary | `#2196F3` | `#64B5F6` | Main actions, links, highlights |
| Primary Light | `#64B5F6` | `#90CAF9` | Hover states, secondary actions |
| Primary Dark | `#1976D2` | `#42A5F5` | Pressed states, active elements |

### Secondary Colors

| Color | Light Mode | Dark Mode | Usage |
|--------|-----------|-----------|--------|
| Secondary | `#7C4DFF` | `#B388FF` | Complementary actions, accents |
| Accent | `#FF4081` | `#FF80AB` | Call-to-action, important elements |

### Semantic Colors

| Color | Light Mode | Dark Mode | Usage |
|--------|-----------|-----------|--------|
| Success | `#4CAF50` | `#81C784` | Success states, confirmations |
| Warning | `#FF9800` | `#FFB74D` | Warning states, cautions |
| Error | `#F44336` | `#E57373` | Error states, destructive actions |
| Info | `#00BCD4` | `#4DD0E1` | Information, tips |

### Neutral Colors

#### Light Mode
- **Background**: `#FAFAFA` - Main application background
- **Surface**: `#FFFFFF` - Cards, panels, dialogs
- **Surface Variant**: `#F5F5F5` - Elevated surfaces
- **On Background**: `#212121` - Primary text
- **On Surface**: `#212121` - Surface text
- **On Surface Variant**: `#757575` - Secondary text
- **Outline**: `#E0E0E0` - Borders, dividers
- **Outline Variant**: `#BDBDBD` - Secondary borders

#### Dark Mode
- **Background**: `#121212` - Main application background
- **Surface**: `#1E1E1E` - Cards, panels, dialogs
- **Surface Variant**: `#2C2C2C` - Elevated surfaces
- **On Background**: `#E0E0E0` - Primary text
- **On Surface**: `#E0E0E0` - Surface text
- **On Surface Variant**: `#B0B0B0` - Secondary text
- **Outline**: `#404040` - Borders, dividers
- **Outline Variant**: `#606060` - Secondary borders

### Color Usage Guidelines

1. **Primary Color**: Use for main actions, links, and interactive elements
2. **Secondary Color**: Use for complementary actions and accents
3. **Semantic Colors**: Use only for their intended purpose (success, warning, error, info)
4. **Neutral Colors**: Use for backgrounds, text, and structural elements
5. **Contrast**: Ensure text has sufficient contrast against backgrounds (WCAG AA: 4.5:1)

---

## Typography

### Font Scale

| Size | Name | Usage | Line Height |
|------|------|--------|-------------|
| 10px | XS | Captions, labels | 1.2 |
| 12px | S | Small text, helpers | 1.5 |
| 14px | M | Body text, buttons | 1.5 |
| 16px | L | Subheadings | 1.5 |
| 18px | XL | Large text | 1.5 |
| 20px | XXL | Headings | 1.5 |
| 24px | Display S | Page titles | 1.2 |
| 32px | Display M | Section titles | 1.2 |
| 48px | Display L | Hero titles | 1.2 |

### Font Weights

| Weight | Name | Usage |
|--------|------|--------|
| Light | 300 | Large headings, decorative text |
| Regular | 400 | Body text, standard elements |
| Medium | 500 | Emphasized text, buttons |
| Semi Bold | 600 | Headings, important elements |
| Bold | 700 | Strong emphasis |

### Letter Spacing

| Value | Name | Usage |
|--------|------|--------|
| -0.5px | Tight | Large headings, uppercase text |
| 0px | Normal | Body text, standard elements |
| 0.5px | Wide | Small text, labels |

### Typography Styles

#### Heading
- **Size**: Display S (24px)
- **Weight**: Semi Bold (600)
- **Line Height**: Tight (1.2)
- **Usage**: Page titles, main headings

#### Subheading
- **Size**: XL (18px)
- **Weight**: Medium (500)
- **Line Height**: Normal (1.5)
- **Usage**: Section headings, card titles

#### Body
- **Size**: M (14px)
- **Weight**: Regular (400)
- **Line Height**: Normal (1.5)
- **Usage**: Paragraph text, descriptions

#### Caption
- **Size**: S (12px)
- **Weight**: Regular (400)
- **Usage**: Labels, helper text, metadata

#### Overline
- **Size**: XS (10px)
- **Weight**: Medium (500)
- **Usage**: Categories, tags, badges

---

## Spacing & Layout

### Spacing Scale

| Value | Name | Usage |
|--------|------|--------|
| 4px | XS | Tight spacing, icon padding |
| 8px | S | Small gaps, compact layouts |
| 16px | M | Standard spacing, default |
| 24px | L | Comfortable spacing, sections |
| 32px | XL | Large spacing, major sections |
| 48px | XXL | Extra large spacing, page margins |
| 64px | XXXL | Maximum spacing, hero sections |

### Padding

| Value | Name | Usage |
|--------|------|--------|
| 4px | Padding XS | Icon buttons, tight controls |
| 8px | Padding S | Small buttons, compact inputs |
| 12px | Padding M | Standard buttons, inputs |
| 16px | Padding L | Large buttons, cards |
| 20px | Padding XL | Extra large buttons, panels |
| 24px | Padding XXL | Maximum padding, dialogs |

### Margin

| Value | Name | Usage |
|--------|------|--------|
| 4px | Margin XS | Tight element spacing |
| 8px | Margin S | Small element spacing |
| 12px | Margin M | Standard element spacing |
| 16px | Margin L | Section spacing |
| 20px | Margin XL | Large section spacing |
| 24px | Margin XXL | Maximum section spacing |

### Border Radius

| Value | Name | Usage |
|--------|------|--------|
| 2px | XS | Small elements, tags |
| 4px | S | Buttons, inputs, cards |
| 8px | M | Large buttons, panels |
| 12px | L | Dialogs, large cards |
| 16px | XL | Extra large elements |
| 999px | Pill | Pills, badges, rounded buttons |

### Border Thickness

| Value | Name | Usage |
|--------|------|--------|
| 1px | Thin | Standard borders, outlines |
| 2px | Medium | Emphasized borders |
| 3px | Thick | Strong emphasis |

---

## Components

### Buttons

#### Primary Button
- **Background**: Primary color
- **Foreground**: On Background color
- **Padding**: Padding M (12px)
- **Border Radius**: CornerRadius M (8px)
- **States**: Normal, Hover, Pressed, Disabled

#### Secondary Button
- **Background**: Secondary color
- **Foreground**: On Background color
- **Padding**: Padding M (12px)
- **Border Radius**: CornerRadius M (8px)
- **States**: Normal, Hover, Pressed, Disabled

#### Outline Button
- **Background**: Transparent
- **Foreground**: Primary color
- **Border**: Outline color, 1px
- **Padding**: Padding M (12px)
- **Border Radius**: CornerRadius M (8px)
- **States**: Normal, Hover, Pressed, Disabled

#### Text Button
- **Background**: Transparent
- **Foreground**: Primary color
- **Padding**: Padding S (8px)
- **States**: Normal, Hover, Pressed, Disabled

#### Icon Button
- **Background**: Transparent
- **Size**: 36px × 36px
- **Padding**: Padding S (8px)
- **States**: Normal, Hover, Pressed, Disabled

### Text Inputs

#### Standard TextBox
- **Background**: Surface color
- **Foreground**: On Surface color
- **Border**: Outline color, 1px
- **Padding**: Padding M (12px)
- **Border Radius**: CornerRadius S (4px)
- **Caret Color**: Primary color
- **States**: Normal, Hover, Focused, Disabled

#### Filled TextBox
- **Background**: Surface Variant color
- **Border**: None
- **Padding**: Padding M (12px)
- **Border Radius**: CornerRadius S (4px)
- **States**: Normal, Hover, Focused, Disabled

#### Outlined TextBox
- **Background**: Transparent
- **Border**: Outline color, 1px
- **Padding**: Padding M (12px)
- **Border Radius**: CornerRadius S (4px)
- **States**: Normal, Hover, Focused, Disabled

### Cards

#### Standard Card
- **Background**: Surface color
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding L (16px)
- **Shadow**: Shadow S
- **Usage**: Content containers, information panels

#### Elevated Card
- **Background**: Surface color
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding L (16px)
- **Shadow**: Shadow M
- **Margin**: Margin S (8px)
- **Usage**: Prominent content, interactive elements

#### Outlined Card
- **Background**: Surface color
- **Border**: Outline color, 1px
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding L (16px)
- **Shadow**: None
- **Usage**: Simple containers, grouped content

### Navigation

#### Breadcrumb
- **Font Size**: S (12px)
- **Color**: On Surface Variant
- **Spacing**: Margin S (8px)
- **Separator**: "/"
- **States**: Normal, Hover

#### Search Box
- **Background**: Surface Variant color
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding M (12px)
- **Shadow**: Shadow XS
- **Margin**: Margin M (16px)

#### Filter Panel
- **Background**: Surface color
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding L (16px)
- **Shadow**: Shadow S
- **Margin**: Margin M (16px)

### Notifications

#### Success Notification
- **Background**: Surface color
- **Border**: Success color, 1px
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding L (16px)
- **Shadow**: Shadow L

#### Warning Notification
- **Background**: Surface color
- **Border**: Warning color, 1px
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding L (16px)
- **Shadow**: Shadow L

#### Error Notification
- **Background**: Surface color
- **Border**: Error color, 1px
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding L (16px)
- **Shadow**: Shadow L

#### Info Notification
- **Background**: Surface color
- **Border**: Info color, 1px
- **Border Radius**: CornerRadius M (8px)
- **Padding**: Padding L (16px)
- **Shadow**: Shadow L

---

## Animations & Interactions

### Animation Durations

| Duration | Name | Usage |
|----------|------|--------|
| 100ms | Instant | Micro-interactions, feedback |
| 200ms | Fast | Hover effects, quick transitions |
| 300ms | Normal | Standard transitions, page changes |
| 500ms | Slow | Complex animations, major transitions |

### Easing Functions

| Function | Name | Usage |
|----------|------|--------|
| Ease Out | Standard | Most animations, natural feel |
| Ease Out | Decelerate | Slowing down animations |
| Ease In | Accelerate | Speeding up animations |

### Transition Animations

#### Fade In
- **Duration**: Normal (300ms)
- **Easing**: Standard (Ease Out)
- **Usage**: Content appearance, modal dialogs

#### Slide In (Left)
- **Duration**: Normal (300ms)
- **Easing**: Standard (Ease Out)
- **Offset**: -50px
- **Usage**: Side panels, navigation

#### Scale In
- **Duration**: Normal (300ms)
- **Easing**: Standard (Ease Out)
- **Scale**: 0.8 → 1.0
- **Usage**: Popups, tooltips, cards

### Interaction Animations

#### Hover Scale
- **Duration**: Fast (200ms)
- **Easing**: Standard (Ease Out)
- **Scale**: 1.0 → 1.05
- **Usage**: Interactive elements, cards

#### Hover Brightness
- **Duration**: Fast (200ms)
- **Opacity**: 1.0 → 0.8
- **Usage**: Images, icons

#### Press Scale
- **Duration**: Instant (100ms)
- **Scale**: 1.0 → 0.95
- **Usage**: Button presses, clicks

### Feedback Animations

#### Loading Spinner
- **Icon**: Circle Outline Notch
- **Duration**: 1s (continuous)
- **Size**: Small (24px), Medium (40px), Large (60px)
- **Usage**: Loading states, processing

#### Pulse Animation
- **Duration**: Slow (500ms)
- **Opacity**: 0.5 → 1.0 (loop)
- **Usage**: Attention indicators, live status

#### Shake Animation
- **Duration**: 500ms
- **Offset**: ±5px
- **Usage**: Error feedback, validation

---

## Responsive Design

### Breakpoints

| Breakpoint | Width | Name | Usage |
|------------|--------|------|--------|
| 480px | XS | Mobile | Small phones |
| 768px | S | Tablet | Tablets, large phones |
| 1024px | M | Desktop | Small laptops, tablets |
| 1280px | L | Desktop | Standard desktops |
| 1600px | XL | Desktop | Large screens |

### Layout Patterns

#### Mobile Layout
- **Margin**: Margin S (8px)
- **Padding**: Padding S (8px)
- **Columns**: 1 column
- **Touch Targets**: Minimum 44px

#### Tablet Layout
- **Margin**: Margin M (16px)
- **Padding**: Padding M (16px)
- **Columns**: 2-3 columns
- **Touch Targets**: Minimum 40px

#### Desktop Layout
- **Margin**: Margin L (24px)
- **Padding**: Padding L (24px)
- **Columns**: 3-4 columns
- **Touch Targets**: Minimum 36px

### Adaptive Strategies

1. **Fluid Widths**: Use relative units and flexible layouts
2. **Progressive Enhancement**: Start with basic layout, enhance for larger screens
3. **Content Priority**: Show most important content first on small screens
4. **Touch Optimization**: Ensure interactive elements are appropriately sized

---

## Accessibility

### Color Contrast

- **WCAG AA**: Minimum 4.5:1 contrast ratio for normal text
- **WCAG AAA**: Minimum 7:1 contrast ratio for large text
- **Testing**: Use color contrast checkers to verify compliance

### Keyboard Navigation

- **Focus Order**: Logical tab order through interactive elements
- **Focus Indicators**: Visible focus states for all interactive elements
- **Shortcuts**: Provide keyboard shortcuts for common actions
- **Skip Links**: Allow users to skip to main content

### Screen Reader Support

- **Semantic HTML**: Use appropriate elements for content structure
- **ARIA Labels**: Provide labels for interactive elements
- **Live Regions**: Announce dynamic content changes
- **Alternative Text**: Describe images and non-text content

### Touch Targets

- **Minimum Size**: 44px × 44px for touch targets
- **Spacing**: At least 8px between touch targets
- **Feedback**: Provide visual and tactile feedback

### Motion & Animation

- **Respect Preferences**: Honor user's motion preferences
- **Reduced Motion**: Provide option to disable animations
- **Duration**: Keep animations under 300ms for essential interactions
- **Purpose**: Ensure animations serve a functional purpose

---

## Best Practices

### Design Guidelines

1. **Consistency**: Use design tokens and predefined components
2. **Hierarchy**: Establish clear visual hierarchy with size, color, and spacing
3. **Whitespace**: Use whitespace effectively to improve readability
4. **Contrast**: Ensure sufficient contrast for accessibility
5. **Feedback**: Provide clear feedback for all user interactions

### Implementation Guidelines

1. **Use Design Tokens**: Reference design tokens instead of hard-coded values
2. **Component Reuse**: Use existing components before creating new ones
3. **Responsive Design**: Test on multiple screen sizes
4. **Performance**: Optimize animations and transitions
5. **Accessibility**: Test with screen readers and keyboard navigation

### Testing Guidelines

1. **Cross-Platform**: Test on Windows, macOS, and Linux
2. **Screen Sizes**: Test on various screen sizes and resolutions
3. **Accessibility**: Test with screen readers and keyboard navigation
4. **Performance**: Monitor performance impact of animations
5. **User Testing**: Conduct usability testing with real users

---

## Resources

### Design Tools

- **Figma**: Design mockups and prototypes
- **Adobe XD**: Interactive prototyping
- **Sketch**: UI design and prototyping

### Development Tools

- **Visual Studio**: WPF development
- **Blend**: Visual design for WPF
- **XAML Styler**: Code formatting

### Accessibility Tools

- **WAVE**: Web accessibility evaluation tool
- **Color Contrast Analyzer**: Contrast ratio checker
- **NVDA**: Screen reader for testing

### Documentation

- **Material Design**: Google's design system
- **Fluent Design**: Microsoft's design system
- **Human Interface Guidelines**: Apple's design guidelines

---

## Version History

| Version | Date | Changes |
|---------|------|--------|
| 1.0.0 | 2026-01-26 | Initial design system release |

---

## Contributing

To contribute to the design system:

1. Follow the established design principles
2. Use design tokens and predefined components
3. Test for accessibility and responsiveness
4. Document any new components or changes
5. Submit changes for review

---

## License

This design system is part of the BerryAIGC project and follows the same license.

---

## Contact

For questions or feedback about the design system, please contact the design team.

---

*Last updated: January 26, 2026*
