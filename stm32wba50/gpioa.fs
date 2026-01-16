\
\ @file gpioa.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GPIO port A mode register
\ Address offset: 0x00
\ Reset value: 0xABFFFFFF
\

$00000003 constant GPIOA_GPIOA_MODER_MODE0                          \ Port configuration I/O pin 0
$0000000c constant GPIOA_GPIOA_MODER_MODE1                          \ Port configuration I/O pin 1
$00000030 constant GPIOA_GPIOA_MODER_MODE2                          \ Port configuration I/O pin 2
$000000c0 constant GPIOA_GPIOA_MODER_MODE3                          \ Port configuration I/O pin 3
$00000c00 constant GPIOA_GPIOA_MODER_MODE5                          \ Port configuration I/O pin 5
$00003000 constant GPIOA_GPIOA_MODER_MODE6                          \ Port configuration I/O pin 6
$0000c000 constant GPIOA_GPIOA_MODER_MODE7                          \ Port configuration I/O pin 7
$00030000 constant GPIOA_GPIOA_MODER_MODE8                          \ Port configuration I/O pin 8
$000c0000 constant GPIOA_GPIOA_MODER_MODE9                          \ Port configuration I/O pin 9
$00300000 constant GPIOA_GPIOA_MODER_MODE10                         \ Port configuration I/O pin 10
$00c00000 constant GPIOA_GPIOA_MODER_MODE11                         \ Port configuration I/O pin 11
$03000000 constant GPIOA_GPIOA_MODER_MODE12                         \ Port configuration I/O pin 12
$0c000000 constant GPIOA_GPIOA_MODER_MODE13                         \ Port configuration I/O pin 13
$30000000 constant GPIOA_GPIOA_MODER_MODE14                         \ Port configuration I/O pin 14
$c0000000 constant GPIOA_GPIOA_MODER_MODE15                         \ Port configuration I/O pin 15 These bits are written by software to configure the I/O mode. Access can be protected by GPIOA SEC15.


\
\ @brief GPIO port A output type register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_OTYPER_OT0                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000002 constant GPIOA_GPIOA_OTYPER_OT1                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000004 constant GPIOA_GPIOA_OTYPER_OT2                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000008 constant GPIOA_GPIOA_OTYPER_OT3                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000020 constant GPIOA_GPIOA_OTYPER_OT5                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000040 constant GPIOA_GPIOA_OTYPER_OT6                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000080 constant GPIOA_GPIOA_OTYPER_OT7                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000100 constant GPIOA_GPIOA_OTYPER_OT8                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000200 constant GPIOA_GPIOA_OTYPER_OT9                           \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000400 constant GPIOA_GPIOA_OTYPER_OT10                          \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00000800 constant GPIOA_GPIOA_OTYPER_OT11                          \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00001000 constant GPIOA_GPIOA_OTYPER_OT12                          \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00002000 constant GPIOA_GPIOA_OTYPER_OT13                          \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00004000 constant GPIOA_GPIOA_OTYPER_OT14                          \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
$00008000 constant GPIOA_GPIOA_OTYPER_OT15                          \ Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.


\
\ @brief GPIO port A output speed register
\ Address offset: 0x08
\ Reset value: 0x08000000
\

$00000003 constant GPIOA_GPIOA_OSPEEDR_OSPEED0                      \ Port configuration I/O pin 0
$0000000c constant GPIOA_GPIOA_OSPEEDR_OSPEED1                      \ Port configuration I/O pin 1
$00000030 constant GPIOA_GPIOA_OSPEEDR_OSPEED2                      \ Port configuration I/O pin 2
$000000c0 constant GPIOA_GPIOA_OSPEEDR_OSPEED3                      \ Port configuration I/O pin 3
$00000c00 constant GPIOA_GPIOA_OSPEEDR_OSPEED5                      \ Port configuration I/O pin 5
$00003000 constant GPIOA_GPIOA_OSPEEDR_OSPEED6                      \ Port configuration I/O pin 6
$0000c000 constant GPIOA_GPIOA_OSPEEDR_OSPEED7                      \ Port configuration I/O pin 7
$00030000 constant GPIOA_GPIOA_OSPEEDR_OSPEED8                      \ Port configuration I/O pin 8
$000c0000 constant GPIOA_GPIOA_OSPEEDR_OSPEED9                      \ Port configuration I/O pin 9
$00300000 constant GPIOA_GPIOA_OSPEEDR_OSPEED10                     \ Port configuration I/O pin 10
$00c00000 constant GPIOA_GPIOA_OSPEEDR_OSPEED11                     \ Port configuration I/O pin 11
$03000000 constant GPIOA_GPIOA_OSPEEDR_OSPEED12                     \ Port configuration I/O pin 12
$0c000000 constant GPIOA_GPIOA_OSPEEDR_OSPEED13                     \ Port configuration I/O pin 13
$30000000 constant GPIOA_GPIOA_OSPEEDR_OSPEED14                     \ Port configuration I/O pin 14
$c0000000 constant GPIOA_GPIOA_OSPEEDR_OSPEED15                     \ Port configuration I/O pin 15 These bits are written by software to configure the I/O output speed. Access can be protected by GPIOA SEC15. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.


\
\ @brief GPIO port A pull-up/pull-down register
\ Address offset: 0x0C
\ Reset value: 0x64000000
\

$00000003 constant GPIOA_GPIOA_PUPDR_PUPD0                          \ Port configuration I/O pin 0
$0000000c constant GPIOA_GPIOA_PUPDR_PUPD1                          \ Port configuration I/O pin 1
$00000030 constant GPIOA_GPIOA_PUPDR_PUPD2                          \ Port configuration I/O pin 2
$000000c0 constant GPIOA_GPIOA_PUPDR_PUPD3                          \ Port configuration I/O pin 3
$00000c00 constant GPIOA_GPIOA_PUPDR_PUPD5                          \ Port configuration I/O pin 5
$00003000 constant GPIOA_GPIOA_PUPDR_PUPD6                          \ Port configuration I/O pin 6
$0000c000 constant GPIOA_GPIOA_PUPDR_PUPD7                          \ Port configuration I/O pin 7
$00030000 constant GPIOA_GPIOA_PUPDR_PUPD8                          \ Port configuration I/O pin 8
$000c0000 constant GPIOA_GPIOA_PUPDR_PUPD9                          \ Port configuration I/O pin 9
$00300000 constant GPIOA_GPIOA_PUPDR_PUPD10                         \ Port configuration I/O pin 10
$00c00000 constant GPIOA_GPIOA_PUPDR_PUPD11                         \ Port configuration I/O pin 11
$03000000 constant GPIOA_GPIOA_PUPDR_PUPD12                         \ Port configuration I/O pin 12
$0c000000 constant GPIOA_GPIOA_PUPDR_PUPD13                         \ Port configuration I/O pin 13
$30000000 constant GPIOA_GPIOA_PUPDR_PUPD14                         \ Port configuration I/O pin 14
$c0000000 constant GPIOA_GPIOA_PUPDR_PUPD15                         \ Port configuration I/O pin 15 These bits are written by software to configure the I/O pull-up or pull-down Access can be protected by GPIOA SEC15.


\
\ @brief GPIO port A input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_IDR_ID0                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000002 constant GPIOA_GPIOA_IDR_ID1                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000004 constant GPIOA_GPIOA_IDR_ID2                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000008 constant GPIOA_GPIOA_IDR_ID3                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000020 constant GPIOA_GPIOA_IDR_ID5                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000040 constant GPIOA_GPIOA_IDR_ID6                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000080 constant GPIOA_GPIOA_IDR_ID7                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000100 constant GPIOA_GPIOA_IDR_ID8                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000200 constant GPIOA_GPIOA_IDR_ID9                              \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000400 constant GPIOA_GPIOA_IDR_ID10                             \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00000800 constant GPIOA_GPIOA_IDR_ID11                             \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00001000 constant GPIOA_GPIOA_IDR_ID12                             \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00002000 constant GPIOA_GPIOA_IDR_ID13                             \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00004000 constant GPIOA_GPIOA_IDR_ID14                             \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
$00008000 constant GPIOA_GPIOA_IDR_ID15                             \ Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.


\
\ @brief GPIO port A output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_ODR_OD0                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers.
$00000002 constant GPIOA_GPIOA_ODR_OD1                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers.
$00000004 constant GPIOA_GPIOA_ODR_OD2                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers.
$00000008 constant GPIOA_GPIOA_ODR_OD3                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers.
$00000020 constant GPIOA_GPIOA_ODR_OD5                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00000040 constant GPIOA_GPIOA_ODR_OD6                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00000080 constant GPIOA_GPIOA_ODR_OD7                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00000100 constant GPIOA_GPIOA_ODR_OD8                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00000200 constant GPIOA_GPIOA_ODR_OD9                              \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00000400 constant GPIOA_GPIOA_ODR_OD10                             \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00000800 constant GPIOA_GPIOA_ODR_OD11                             \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00001000 constant GPIOA_GPIOA_ODR_OD12                             \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00002000 constant GPIOA_GPIOA_ODR_OD13                             \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00004000 constant GPIOA_GPIOA_ODR_OD14                             \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
$00008000 constant GPIOA_GPIOA_ODR_OD15                             \ Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .


\
\ @brief GPIO port A bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_BSRR_BS0                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000002 constant GPIOA_GPIOA_BSRR_BS1                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000004 constant GPIOA_GPIOA_BSRR_BS2                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000008 constant GPIOA_GPIOA_BSRR_BS3                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000020 constant GPIOA_GPIOA_BSRR_BS5                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000040 constant GPIOA_GPIOA_BSRR_BS6                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000080 constant GPIOA_GPIOA_BSRR_BS7                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000100 constant GPIOA_GPIOA_BSRR_BS8                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000200 constant GPIOA_GPIOA_BSRR_BS9                             \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000400 constant GPIOA_GPIOA_BSRR_BS10                            \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00000800 constant GPIOA_GPIOA_BSRR_BS11                            \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00001000 constant GPIOA_GPIOA_BSRR_BS12                            \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00002000 constant GPIOA_GPIOA_BSRR_BS13                            \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00004000 constant GPIOA_GPIOA_BSRR_BS14                            \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00008000 constant GPIOA_GPIOA_BSRR_BS15                            \ Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
$00010000 constant GPIOA_GPIOA_BSRR_BR0                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$00020000 constant GPIOA_GPIOA_BSRR_BR1                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$00040000 constant GPIOA_GPIOA_BSRR_BR2                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$00080000 constant GPIOA_GPIOA_BSRR_BR3                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$00200000 constant GPIOA_GPIOA_BSRR_BR5                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$00400000 constant GPIOA_GPIOA_BSRR_BR6                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$00800000 constant GPIOA_GPIOA_BSRR_BR7                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$01000000 constant GPIOA_GPIOA_BSRR_BR8                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$02000000 constant GPIOA_GPIOA_BSRR_BR9                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$04000000 constant GPIOA_GPIOA_BSRR_BR10                            \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$08000000 constant GPIOA_GPIOA_BSRR_BR11                            \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$10000000 constant GPIOA_GPIOA_BSRR_BR12                            \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$20000000 constant GPIOA_GPIOA_BSRR_BR13                            \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$40000000 constant GPIOA_GPIOA_BSRR_BR14                            \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
$80000000 constant GPIOA_GPIOA_BSRR_BR15                            \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.


\
\ @brief GPIO port A configuration lock register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_LCKR_LCK0                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000002 constant GPIOA_GPIOA_LCKR_LCK1                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000004 constant GPIOA_GPIOA_LCKR_LCK2                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000008 constant GPIOA_GPIOA_LCKR_LCK3                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000020 constant GPIOA_GPIOA_LCKR_LCK5                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000040 constant GPIOA_GPIOA_LCKR_LCK6                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000080 constant GPIOA_GPIOA_LCKR_LCK7                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000100 constant GPIOA_GPIOA_LCKR_LCK8                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000200 constant GPIOA_GPIOA_LCKR_LCK9                            \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000400 constant GPIOA_GPIOA_LCKR_LCK10                           \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00000800 constant GPIOA_GPIOA_LCKR_LCK11                           \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00001000 constant GPIOA_GPIOA_LCKR_LCK12                           \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00002000 constant GPIOA_GPIOA_LCKR_LCK13                           \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00004000 constant GPIOA_GPIOA_LCKR_LCK14                           \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00008000 constant GPIOA_GPIOA_LCKR_LCK15                           \ Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
$00010000 constant GPIOA_GPIOA_LCKR_LCKK                            \ Lock key This bit can be read any time. It can only be modified using the lock key write sequence. Access can be protected by any GPIOA SECy. - LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] - LOCK key read RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCKR[15:0] must not change. Note: Any error in the lock sequence aborts the LOCK. Note: After the first LOCK sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.


\
\ @brief GPIO port A alternate function low register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_GPIOA_AFRL_AFSEL0                          \ Alternate function selection for port I/O pin 0
$000000f0 constant GPIOA_GPIOA_AFRL_AFSEL1                          \ Alternate function selection for port I/O pin 1
$00000f00 constant GPIOA_GPIOA_AFRL_AFSEL2                          \ Alternate function selection for port I/O pin 2
$0000f000 constant GPIOA_GPIOA_AFRL_AFSEL3                          \ Alternate function selection for port I/O pin 3
$00f00000 constant GPIOA_GPIOA_AFRL_AFSEL5                          \ Alternate function selection for port I/O pin 5
$0f000000 constant GPIOA_GPIOA_AFRL_AFSEL6                          \ Alternate function selection for port I/O pin 6
$f0000000 constant GPIOA_GPIOA_AFRL_AFSEL7                          \ Alternate function selection for port I/O pin 7 These bits are written by software to configure alternate function I/Os. Access can be protected by GPIOA SECy.


\
\ @brief GPIO port A alternate function high register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant GPIOA_GPIOA_AFRH_AFSEL8                          \ Alternate function selection for port I/O pin 8
$000000f0 constant GPIOA_GPIOA_AFRH_AFSEL9                          \ Alternate function selection for port I/O pin 9
$00000f00 constant GPIOA_GPIOA_AFRH_AFSEL10                         \ Alternate function selection for port I/O pin 10
$0000f000 constant GPIOA_GPIOA_AFRH_AFSEL11                         \ Alternate function selection for port I/O pin 11
$000f0000 constant GPIOA_GPIOA_AFRH_AFSEL12                         \ Alternate function selection for port I/O pin 12
$00f00000 constant GPIOA_GPIOA_AFRH_AFSEL13                         \ Alternate function selection for port I/O pin 13
$0f000000 constant GPIOA_GPIOA_AFRH_AFSEL14                         \ Alternate function selection for port I/O pin 14
$f0000000 constant GPIOA_GPIOA_AFRH_AFSEL15                         \ Alternate function selection for port I/O pin 15 These bits are written by software to configure alternate function I/Os. Access can be protected by GPIOA SEC15.


\
\ @brief GPIO port A bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GPIOA_GPIOA_BRR_BR0                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000002 constant GPIOA_GPIOA_BRR_BR1                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000004 constant GPIOA_GPIOA_BRR_BR2                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000008 constant GPIOA_GPIOA_BRR_BR3                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000020 constant GPIOA_GPIOA_BRR_BR5                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000040 constant GPIOA_GPIOA_BRR_BR6                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000080 constant GPIOA_GPIOA_BRR_BR7                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000100 constant GPIOA_GPIOA_BRR_BR8                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000200 constant GPIOA_GPIOA_BRR_BR9                              \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000400 constant GPIOA_GPIOA_BRR_BR10                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00000800 constant GPIOA_GPIOA_BRR_BR11                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00001000 constant GPIOA_GPIOA_BRR_BR12                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00002000 constant GPIOA_GPIOA_BRR_BR13                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00004000 constant GPIOA_GPIOA_BRR_BR14                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
$00008000 constant GPIOA_GPIOA_BRR_BR15                             \ Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.


\
\ @brief GPIO port A secure configuration register
\ Address offset: 0x30
\ Reset value: 0x0000FFFF
\

$00000001 constant GPIOA_GPIOA_SECCFGR_SEC0                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000002 constant GPIOA_GPIOA_SECCFGR_SEC1                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000004 constant GPIOA_GPIOA_SECCFGR_SEC2                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000008 constant GPIOA_GPIOA_SECCFGR_SEC3                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000020 constant GPIOA_GPIOA_SECCFGR_SEC5                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000040 constant GPIOA_GPIOA_SECCFGR_SEC6                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000080 constant GPIOA_GPIOA_SECCFGR_SEC7                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000100 constant GPIOA_GPIOA_SECCFGR_SEC8                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000200 constant GPIOA_GPIOA_SECCFGR_SEC9                         \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000400 constant GPIOA_GPIOA_SECCFGR_SEC10                        \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00000800 constant GPIOA_GPIOA_SECCFGR_SEC11                        \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00001000 constant GPIOA_GPIOA_SECCFGR_SEC12                        \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00002000 constant GPIOA_GPIOA_SECCFGR_SEC13                        \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00004000 constant GPIOA_GPIOA_SECCFGR_SEC14                        \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
$00008000 constant GPIOA_GPIOA_SECCFGR_SEC15                        \ I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.


\
\ @brief General-purpose I/Os
\
$42020000 constant GPIOA_GPIOA_MODER  \ offset: 0x00 : GPIO port A mode register
$42020004 constant GPIOA_GPIOA_OTYPER  \ offset: 0x04 : GPIO port A output type register
$42020008 constant GPIOA_GPIOA_OSPEEDR  \ offset: 0x08 : GPIO port A output speed register
$4202000c constant GPIOA_GPIOA_PUPDR  \ offset: 0x0C : GPIO port A pull-up/pull-down register
$42020010 constant GPIOA_GPIOA_IDR  \ offset: 0x10 : GPIO port A input data register
$42020014 constant GPIOA_GPIOA_ODR  \ offset: 0x14 : GPIO port A output data register
$42020018 constant GPIOA_GPIOA_BSRR  \ offset: 0x18 : GPIO port A bit set/reset register
$4202001c constant GPIOA_GPIOA_LCKR  \ offset: 0x1C : GPIO port A configuration lock register
$42020020 constant GPIOA_GPIOA_AFRL  \ offset: 0x20 : GPIO port A alternate function low register
$42020024 constant GPIOA_GPIOA_AFRH  \ offset: 0x24 : GPIO port A alternate function high register
$42020028 constant GPIOA_GPIOA_BRR  \ offset: 0x28 : GPIO port A bit reset register
$42020030 constant GPIOA_GPIOA_SECCFGR  \ offset: 0x30 : GPIO port A secure configuration register

