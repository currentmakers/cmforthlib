\
\ @file fpu.fs
\ @brief Floting point unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Floating-point context control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant FPU_FPCCR_LSPACT                                 \ LSPACT
$00000002 constant FPU_FPCCR_USER                                   \ USER
$00000008 constant FPU_FPCCR_THREAD                                 \ THREAD
$00000010 constant FPU_FPCCR_HFRDY                                  \ HFRDY
$00000020 constant FPU_FPCCR_MMRDY                                  \ MMRDY
$00000040 constant FPU_FPCCR_BFRDY                                  \ BFRDY
$00000100 constant FPU_FPCCR_MONRDY                                 \ MONRDY
$40000000 constant FPU_FPCCR_LSPEN                                  \ LSPEN
$80000000 constant FPU_FPCCR_ASPEN                                  \ ASPEN


\
\ @brief Floating-point context address register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$fffffff8 constant FPU_FPCAR_ADDRESS                                \ Location of unpopulated floating-point


\
\ @brief Floating-point status control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant FPU_FPSCR_IOC                                    \ Invalid operation cumulative exception bit
$00000002 constant FPU_FPSCR_DZC                                    \ Division by zero cumulative exception bit.
$00000004 constant FPU_FPSCR_OFC                                    \ Overflow cumulative exception bit
$00000008 constant FPU_FPSCR_UFC                                    \ Underflow cumulative exception bit
$00000010 constant FPU_FPSCR_IXC                                    \ Inexact cumulative exception bit
$00000080 constant FPU_FPSCR_IDC                                    \ Input denormal cumulative exception bit.
$00c00000 constant FPU_FPSCR_RMODE                                  \ Rounding Mode control field
$01000000 constant FPU_FPSCR_FZ                                     \ Flush-to-zero mode control bit:
$02000000 constant FPU_FPSCR_DN                                     \ Default NaN mode control bit
$04000000 constant FPU_FPSCR_AHP                                    \ Alternative half-precision control bit
$10000000 constant FPU_FPSCR_V                                      \ Overflow condition code flag
$20000000 constant FPU_FPSCR_C                                      \ Carry condition code flag
$40000000 constant FPU_FPSCR_Z                                      \ Zero condition code flag
$80000000 constant FPU_FPSCR_N                                      \ Negative condition code flag


\
\ @brief Floting point unit
\
$e000ef34 constant FPU_FPCCR      \ offset: 0x00 : Floating-point context control register
$e000ef38 constant FPU_FPCAR      \ offset: 0x04 : Floating-point context address register
$e000ef3c constant FPU_FPSCR      \ offset: 0x08 : Floating-point status control register

