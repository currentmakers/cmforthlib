\
\ @file sec_lpgpio1.fs
\ @brief LPGPIO1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPGPIO port mode register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPGPIO1_LPGPIO_MODER_MODE0                   \ MODE0
$00000002 constant SEC_LPGPIO1_LPGPIO_MODER_MODE1                   \ MODE1
$00000004 constant SEC_LPGPIO1_LPGPIO_MODER_MODE2                   \ MODE2
$00000008 constant SEC_LPGPIO1_LPGPIO_MODER_MODE3                   \ MODE3
$00000010 constant SEC_LPGPIO1_LPGPIO_MODER_MODE4                   \ MODE4
$00000020 constant SEC_LPGPIO1_LPGPIO_MODER_MODE5                   \ MODE5
$00000040 constant SEC_LPGPIO1_LPGPIO_MODER_MODE6                   \ MODE6
$00000080 constant SEC_LPGPIO1_LPGPIO_MODER_MODE7                   \ MODE7
$00000100 constant SEC_LPGPIO1_LPGPIO_MODER_MODE8                   \ MODE8
$00000200 constant SEC_LPGPIO1_LPGPIO_MODER_MODE9                   \ MODE9
$00000400 constant SEC_LPGPIO1_LPGPIO_MODER_MODE10                  \ MODE10
$00000800 constant SEC_LPGPIO1_LPGPIO_MODER_MODE11                  \ MODE11
$00001000 constant SEC_LPGPIO1_LPGPIO_MODER_MODE12                  \ MODE12
$00002000 constant SEC_LPGPIO1_LPGPIO_MODER_MODE13                  \ MODE13
$00004000 constant SEC_LPGPIO1_LPGPIO_MODER_MODE14                  \ MODE14
$00008000 constant SEC_LPGPIO1_LPGPIO_MODER_MODE15                  \ MODE15


\
\ @brief LPGPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPGPIO1_LPGPIO_IDR_IDY                       \ IDy


\
\ @brief LPGPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPGPIO1_LPGPIO_ODR_ODY0                      \ ODy0
$00000002 constant SEC_LPGPIO1_LPGPIO_ODR_ODY1                      \ ODy1
$00000004 constant SEC_LPGPIO1_LPGPIO_ODR_ODY2                      \ ODy2
$00000008 constant SEC_LPGPIO1_LPGPIO_ODR_ODY3                      \ ODy3
$00000010 constant SEC_LPGPIO1_LPGPIO_ODR_ODY4                      \ ODy4
$00000020 constant SEC_LPGPIO1_LPGPIO_ODR_ODY5                      \ ODy5
$00000040 constant SEC_LPGPIO1_LPGPIO_ODR_ODY6                      \ ODy6
$00000080 constant SEC_LPGPIO1_LPGPIO_ODR_ODY7                      \ ODy7
$00000100 constant SEC_LPGPIO1_LPGPIO_ODR_ODY8                      \ ODy8
$00000200 constant SEC_LPGPIO1_LPGPIO_ODR_ODY9                      \ ODy9
$00000400 constant SEC_LPGPIO1_LPGPIO_ODR_ODY10                     \ ODy10
$00000800 constant SEC_LPGPIO1_LPGPIO_ODR_ODY11                     \ ODy11
$00001000 constant SEC_LPGPIO1_LPGPIO_ODR_ODY12                     \ ODy12
$00002000 constant SEC_LPGPIO1_LPGPIO_ODR_ODY13                     \ ODy13
$00004000 constant SEC_LPGPIO1_LPGPIO_ODR_ODY14                     \ ODy14
$00008000 constant SEC_LPGPIO1_LPGPIO_ODR_ODY15                     \ ODy15


\
\ @brief LPGPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY0                     \ BSy0
$00000002 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY1                     \ BSy1
$00000004 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY2                     \ BSy2
$00000008 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY3                     \ BSy3
$00000010 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY4                     \ BSy4
$00000020 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY5                     \ BSy5
$00000040 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY6                     \ BSy6
$00000080 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY7                     \ BSy7
$00000100 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY8                     \ BSy8
$00000200 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY9                     \ BSy9
$00000400 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY10                    \ BSy10
$00000800 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY11                    \ BSy11
$00001000 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY12                    \ BSy12
$00002000 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY13                    \ BSy13
$00004000 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY14                    \ BSy14
$00008000 constant SEC_LPGPIO1_LPGPIO_BSRR_BSY15                    \ BSy15
$00010000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY16                    \ BRy16
$00020000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY17                    \ BRy17
$00040000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY18                    \ BRy18
$00080000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY19                    \ BRy19
$00100000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY20                    \ BRy20
$00200000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY21                    \ BRy21
$00400000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY22                    \ BRy22
$00800000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY23                    \ BRy23
$01000000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY24                    \ BRy24
$02000000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY25                    \ BRy25
$04000000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY26                    \ BRy26
$08000000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY27                    \ BRy27
$10000000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY28                    \ BRy28
$20000000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY29                    \ BRy29
$40000000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY30                    \ BRy30
$80000000 constant SEC_LPGPIO1_LPGPIO_BSRR_BRY31                    \ BRy31


\
\ @brief LPGPIO port bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPGPIO1_LPGPIO_BRR_BRY0                      \ BRy0
$00000002 constant SEC_LPGPIO1_LPGPIO_BRR_BRY1                      \ BRy1
$00000004 constant SEC_LPGPIO1_LPGPIO_BRR_BRY2                      \ BRy2
$00000008 constant SEC_LPGPIO1_LPGPIO_BRR_BRY3                      \ BRy3
$00000010 constant SEC_LPGPIO1_LPGPIO_BRR_BRY4                      \ BRy4
$00000020 constant SEC_LPGPIO1_LPGPIO_BRR_BRY5                      \ BRy5
$00000040 constant SEC_LPGPIO1_LPGPIO_BRR_BRY6                      \ BRy6
$00000080 constant SEC_LPGPIO1_LPGPIO_BRR_BRY7                      \ BRy7
$00000100 constant SEC_LPGPIO1_LPGPIO_BRR_BRY8                      \ BRy8
$00000200 constant SEC_LPGPIO1_LPGPIO_BRR_BRY9                      \ BRy9
$00000400 constant SEC_LPGPIO1_LPGPIO_BRR_BRY10                     \ BRy10
$00000800 constant SEC_LPGPIO1_LPGPIO_BRR_BRY11                     \ BRy11
$00001000 constant SEC_LPGPIO1_LPGPIO_BRR_BRY12                     \ BRy12
$00002000 constant SEC_LPGPIO1_LPGPIO_BRR_BRY13                     \ BRy13
$00004000 constant SEC_LPGPIO1_LPGPIO_BRR_BRY14                     \ BRy14
$00008000 constant SEC_LPGPIO1_LPGPIO_BRR_BRY15                     \ BRy15


\
\ @brief LPGPIO1
\
$56020000 constant SEC_LPGPIO1_LPGPIO_MODER  \ offset: 0x00 : LPGPIO port mode register
$56020010 constant SEC_LPGPIO1_LPGPIO_IDR  \ offset: 0x10 : LPGPIO port input data register
$56020014 constant SEC_LPGPIO1_LPGPIO_ODR  \ offset: 0x14 : LPGPIO port output data register
$56020018 constant SEC_LPGPIO1_LPGPIO_BSRR  \ offset: 0x18 : LPGPIO port bit set/reset register
$56020028 constant SEC_LPGPIO1_LPGPIO_BRR  \ offset: 0x28 : LPGPIO port bit reset register

