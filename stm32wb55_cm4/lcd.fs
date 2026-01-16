\
\ @file lcd.fs
\ @brief Liquid crystal display controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LCD_CR_LCDEN                                     \ LCD controller enable
$00000002 constant LCD_CR_VSEL                                      \ Voltage source selection
$0000001c constant LCD_CR_DUTY                                      \ Duty selection
$00000060 constant LCD_CR_BIAS                                      \ Bias selector
$00000080 constant LCD_CR_MUX_SEG                                   \ Mux segment enable
$00000100 constant LCD_CR_BUFEN                                     \ Voltage output buffer enable


\
\ @brief frame control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LCD_FCR_HD                                       \ High drive enable
$00000002 constant LCD_FCR_SOFIE                                    \ Start of frame interrupt enable
$00000008 constant LCD_FCR_UDDIE                                    \ Update display done interrupt enable
$00000070 constant LCD_FCR_PON                                      \ Pulse ON duration
$00000380 constant LCD_FCR_DEAD                                     \ Dead time duration
$00001c00 constant LCD_FCR_CC                                       \ Contrast control
$0000e000 constant LCD_FCR_BLINKF                                   \ Blink frequency selection
$00030000 constant LCD_FCR_BLINK                                    \ Blink mode selection
$003c0000 constant LCD_FCR_DIV                                      \ DIV clock divider
$03c00000 constant LCD_FCR_PS                                       \ PS 16-bit prescaler


\
\ @brief status register
\ Address offset: 0x08
\ Reset value: 0x00000020
\

$00000001 constant LCD_SR_ENS                                       \ ENS
$00000002 constant LCD_SR_SOF                                       \ Start of frame flag
$00000004 constant LCD_SR_UDR                                       \ Update display request
$00000008 constant LCD_SR_UDD                                       \ Update Display Done
$00000010 constant LCD_SR_RDY                                       \ Ready flag
$00000020 constant LCD_SR_FCRSF                                     \ LCD Frame Control Register Synchronization flag


\
\ @brief clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant LCD_CLR_SOFC                                     \ Start of frame flag clear
$00000008 constant LCD_CLR_UDDC                                     \ Update display done clear


\
\ @brief display memory
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM0_S00                                 \ S00
$00000002 constant LCD_RAM_COM0_S01                                 \ S01
$00000004 constant LCD_RAM_COM0_S02                                 \ S02
$00000008 constant LCD_RAM_COM0_S03                                 \ S03
$00000010 constant LCD_RAM_COM0_S04                                 \ S04
$00000020 constant LCD_RAM_COM0_S05                                 \ S05
$00000040 constant LCD_RAM_COM0_S06                                 \ S06
$00000080 constant LCD_RAM_COM0_S07                                 \ S07
$00000100 constant LCD_RAM_COM0_S08                                 \ S08
$00000200 constant LCD_RAM_COM0_S09                                 \ S09
$00000400 constant LCD_RAM_COM0_S10                                 \ S10
$00000800 constant LCD_RAM_COM0_S11                                 \ S11
$00001000 constant LCD_RAM_COM0_S12                                 \ S12
$00002000 constant LCD_RAM_COM0_S13                                 \ S13
$00004000 constant LCD_RAM_COM0_S14                                 \ S14
$00008000 constant LCD_RAM_COM0_S15                                 \ S15
$00010000 constant LCD_RAM_COM0_S16                                 \ S16
$00020000 constant LCD_RAM_COM0_S17                                 \ S17
$00040000 constant LCD_RAM_COM0_S18                                 \ S18
$00080000 constant LCD_RAM_COM0_S19                                 \ S19
$00100000 constant LCD_RAM_COM0_S20                                 \ S20
$00200000 constant LCD_RAM_COM0_S21                                 \ S21
$00400000 constant LCD_RAM_COM0_S22                                 \ S22
$00800000 constant LCD_RAM_COM0_S23                                 \ S23
$01000000 constant LCD_RAM_COM0_S24                                 \ S24
$02000000 constant LCD_RAM_COM0_S25                                 \ S25
$04000000 constant LCD_RAM_COM0_S26                                 \ S26
$08000000 constant LCD_RAM_COM0_S27                                 \ S27
$10000000 constant LCD_RAM_COM0_S28                                 \ S28
$20000000 constant LCD_RAM_COM0_S29                                 \ S29
$40000000 constant LCD_RAM_COM0_S30                                 \ S30
$80000000 constant LCD_RAM_COM0_S31                                 \ S31


\
\ @brief display memory
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM1_S00                                 \ S00
$00000002 constant LCD_RAM_COM1_S01                                 \ S01
$00000004 constant LCD_RAM_COM1_S02                                 \ S02
$00000008 constant LCD_RAM_COM1_S03                                 \ S03
$00000010 constant LCD_RAM_COM1_S04                                 \ S04
$00000020 constant LCD_RAM_COM1_S05                                 \ S05
$00000040 constant LCD_RAM_COM1_S06                                 \ S06
$00000080 constant LCD_RAM_COM1_S07                                 \ S07
$00000100 constant LCD_RAM_COM1_S08                                 \ S08
$00000200 constant LCD_RAM_COM1_S09                                 \ S09
$00000400 constant LCD_RAM_COM1_S10                                 \ S10
$00000800 constant LCD_RAM_COM1_S11                                 \ S11
$00001000 constant LCD_RAM_COM1_S12                                 \ S12
$00002000 constant LCD_RAM_COM1_S13                                 \ S13
$00004000 constant LCD_RAM_COM1_S14                                 \ S14
$00008000 constant LCD_RAM_COM1_S15                                 \ S15
$00010000 constant LCD_RAM_COM1_S16                                 \ S16
$00020000 constant LCD_RAM_COM1_S17                                 \ S17
$00040000 constant LCD_RAM_COM1_S18                                 \ S18
$00080000 constant LCD_RAM_COM1_S19                                 \ S19
$00100000 constant LCD_RAM_COM1_S20                                 \ S20
$00200000 constant LCD_RAM_COM1_S21                                 \ S21
$00400000 constant LCD_RAM_COM1_S22                                 \ S22
$00800000 constant LCD_RAM_COM1_S23                                 \ S23
$01000000 constant LCD_RAM_COM1_S24                                 \ S24
$02000000 constant LCD_RAM_COM1_S25                                 \ S25
$04000000 constant LCD_RAM_COM1_S26                                 \ S26
$08000000 constant LCD_RAM_COM1_S27                                 \ S27
$10000000 constant LCD_RAM_COM1_S28                                 \ S28
$20000000 constant LCD_RAM_COM1_S29                                 \ S29
$40000000 constant LCD_RAM_COM1_S30                                 \ S30
$80000000 constant LCD_RAM_COM1_S31                                 \ S31


\
\ @brief display memory
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM2_S00                                 \ S00
$00000002 constant LCD_RAM_COM2_S01                                 \ S01
$00000004 constant LCD_RAM_COM2_S02                                 \ S02
$00000008 constant LCD_RAM_COM2_S03                                 \ S03
$00000010 constant LCD_RAM_COM2_S04                                 \ S04
$00000020 constant LCD_RAM_COM2_S05                                 \ S05
$00000040 constant LCD_RAM_COM2_S06                                 \ S06
$00000080 constant LCD_RAM_COM2_S07                                 \ S07
$00000100 constant LCD_RAM_COM2_S08                                 \ S08
$00000200 constant LCD_RAM_COM2_S09                                 \ S09
$00000400 constant LCD_RAM_COM2_S10                                 \ S10
$00000800 constant LCD_RAM_COM2_S11                                 \ S11
$00001000 constant LCD_RAM_COM2_S12                                 \ S12
$00002000 constant LCD_RAM_COM2_S13                                 \ S13
$00004000 constant LCD_RAM_COM2_S14                                 \ S14
$00008000 constant LCD_RAM_COM2_S15                                 \ S15
$00010000 constant LCD_RAM_COM2_S16                                 \ S16
$00020000 constant LCD_RAM_COM2_S17                                 \ S17
$00040000 constant LCD_RAM_COM2_S18                                 \ S18
$00080000 constant LCD_RAM_COM2_S19                                 \ S19
$00100000 constant LCD_RAM_COM2_S20                                 \ S20
$00200000 constant LCD_RAM_COM2_S21                                 \ S21
$00400000 constant LCD_RAM_COM2_S22                                 \ S22
$00800000 constant LCD_RAM_COM2_S23                                 \ S23
$01000000 constant LCD_RAM_COM2_S24                                 \ S24
$02000000 constant LCD_RAM_COM2_S25                                 \ S25
$04000000 constant LCD_RAM_COM2_S26                                 \ S26
$08000000 constant LCD_RAM_COM2_S27                                 \ S27
$10000000 constant LCD_RAM_COM2_S28                                 \ S28
$20000000 constant LCD_RAM_COM2_S29                                 \ S29
$40000000 constant LCD_RAM_COM2_S30                                 \ S30
$80000000 constant LCD_RAM_COM2_S31                                 \ S31


\
\ @brief display memory
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM3_S00                                 \ S00
$00000002 constant LCD_RAM_COM3_S01                                 \ S01
$00000004 constant LCD_RAM_COM3_S02                                 \ S02
$00000008 constant LCD_RAM_COM3_S03                                 \ S03
$00000010 constant LCD_RAM_COM3_S04                                 \ S04
$00000020 constant LCD_RAM_COM3_S05                                 \ S05
$00000040 constant LCD_RAM_COM3_S06                                 \ S06
$00000080 constant LCD_RAM_COM3_S07                                 \ S07
$00000100 constant LCD_RAM_COM3_S08                                 \ S08
$00000200 constant LCD_RAM_COM3_S09                                 \ S09
$00000400 constant LCD_RAM_COM3_S10                                 \ S10
$00000800 constant LCD_RAM_COM3_S11                                 \ S11
$00001000 constant LCD_RAM_COM3_S12                                 \ S12
$00002000 constant LCD_RAM_COM3_S13                                 \ S13
$00004000 constant LCD_RAM_COM3_S14                                 \ S14
$00008000 constant LCD_RAM_COM3_S15                                 \ S15
$00010000 constant LCD_RAM_COM3_S16                                 \ S16
$00020000 constant LCD_RAM_COM3_S17                                 \ S17
$00040000 constant LCD_RAM_COM3_S18                                 \ S18
$00080000 constant LCD_RAM_COM3_S19                                 \ S19
$00100000 constant LCD_RAM_COM3_S20                                 \ S20
$00200000 constant LCD_RAM_COM3_S21                                 \ S21
$00400000 constant LCD_RAM_COM3_S22                                 \ S22
$00800000 constant LCD_RAM_COM3_S23                                 \ S23
$01000000 constant LCD_RAM_COM3_S24                                 \ S24
$02000000 constant LCD_RAM_COM3_S25                                 \ S25
$04000000 constant LCD_RAM_COM3_S26                                 \ S26
$08000000 constant LCD_RAM_COM3_S27                                 \ S27
$10000000 constant LCD_RAM_COM3_S28                                 \ S28
$20000000 constant LCD_RAM_COM3_S29                                 \ S29
$40000000 constant LCD_RAM_COM3_S30                                 \ S30
$80000000 constant LCD_RAM_COM3_S31                                 \ S31


\
\ @brief display memory
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM4_S00                                 \ S00
$00000002 constant LCD_RAM_COM4_S01                                 \ S01
$00000004 constant LCD_RAM_COM4_S02                                 \ S02
$00000008 constant LCD_RAM_COM4_S03                                 \ S03
$00000010 constant LCD_RAM_COM4_S04                                 \ S04
$00000020 constant LCD_RAM_COM4_S05                                 \ S05
$00000040 constant LCD_RAM_COM4_S06                                 \ S06
$00000080 constant LCD_RAM_COM4_S07                                 \ S07
$00000100 constant LCD_RAM_COM4_S08                                 \ S08
$00000200 constant LCD_RAM_COM4_S09                                 \ S09
$00000400 constant LCD_RAM_COM4_S10                                 \ S10
$00000800 constant LCD_RAM_COM4_S11                                 \ S11
$00001000 constant LCD_RAM_COM4_S12                                 \ S12
$00002000 constant LCD_RAM_COM4_S13                                 \ S13
$00004000 constant LCD_RAM_COM4_S14                                 \ S14
$00008000 constant LCD_RAM_COM4_S15                                 \ S15
$00010000 constant LCD_RAM_COM4_S16                                 \ S16
$00020000 constant LCD_RAM_COM4_S17                                 \ S17
$00040000 constant LCD_RAM_COM4_S18                                 \ S18
$00080000 constant LCD_RAM_COM4_S19                                 \ S19
$00100000 constant LCD_RAM_COM4_S20                                 \ S20
$00200000 constant LCD_RAM_COM4_S21                                 \ S21
$00400000 constant LCD_RAM_COM4_S22                                 \ S22
$00800000 constant LCD_RAM_COM4_S23                                 \ S23
$01000000 constant LCD_RAM_COM4_S24                                 \ S24
$02000000 constant LCD_RAM_COM4_S25                                 \ S25
$04000000 constant LCD_RAM_COM4_S26                                 \ S26
$08000000 constant LCD_RAM_COM4_S27                                 \ S27
$10000000 constant LCD_RAM_COM4_S28                                 \ S28
$20000000 constant LCD_RAM_COM4_S29                                 \ S29
$40000000 constant LCD_RAM_COM4_S30                                 \ S30
$80000000 constant LCD_RAM_COM4_S31                                 \ S31


\
\ @brief display memory
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM5_S00                                 \ S00
$00000002 constant LCD_RAM_COM5_S01                                 \ S01
$00000004 constant LCD_RAM_COM5_S02                                 \ S02
$00000008 constant LCD_RAM_COM5_S03                                 \ S03
$00000010 constant LCD_RAM_COM5_S04                                 \ S04
$00000020 constant LCD_RAM_COM5_S05                                 \ S05
$00000040 constant LCD_RAM_COM5_S06                                 \ S06
$00000080 constant LCD_RAM_COM5_S07                                 \ S07
$00000100 constant LCD_RAM_COM5_S08                                 \ S08
$00000200 constant LCD_RAM_COM5_S09                                 \ S09
$00000400 constant LCD_RAM_COM5_S10                                 \ S10
$00000800 constant LCD_RAM_COM5_S11                                 \ S11
$00001000 constant LCD_RAM_COM5_S12                                 \ S12
$00002000 constant LCD_RAM_COM5_S13                                 \ S13
$00004000 constant LCD_RAM_COM5_S14                                 \ S14
$00008000 constant LCD_RAM_COM5_S15                                 \ S15
$00010000 constant LCD_RAM_COM5_S16                                 \ S16
$00020000 constant LCD_RAM_COM5_S17                                 \ S17
$00040000 constant LCD_RAM_COM5_S18                                 \ S18
$00080000 constant LCD_RAM_COM5_S19                                 \ S19
$00100000 constant LCD_RAM_COM5_S20                                 \ S20
$00200000 constant LCD_RAM_COM5_S21                                 \ S21
$00400000 constant LCD_RAM_COM5_S22                                 \ S22
$00800000 constant LCD_RAM_COM5_S23                                 \ S23
$01000000 constant LCD_RAM_COM5_S24                                 \ S24
$02000000 constant LCD_RAM_COM5_S25                                 \ S25
$04000000 constant LCD_RAM_COM5_S26                                 \ S26
$08000000 constant LCD_RAM_COM5_S27                                 \ S27
$10000000 constant LCD_RAM_COM5_S28                                 \ S28
$20000000 constant LCD_RAM_COM5_S29                                 \ S29
$40000000 constant LCD_RAM_COM5_S30                                 \ S30
$80000000 constant LCD_RAM_COM5_S31                                 \ S31


\
\ @brief display memory
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM6_S00                                 \ S00
$00000002 constant LCD_RAM_COM6_S01                                 \ S01
$00000004 constant LCD_RAM_COM6_S02                                 \ S02
$00000008 constant LCD_RAM_COM6_S03                                 \ S03
$00000010 constant LCD_RAM_COM6_S04                                 \ S04
$00000020 constant LCD_RAM_COM6_S05                                 \ S05
$00000040 constant LCD_RAM_COM6_S06                                 \ S06
$00000080 constant LCD_RAM_COM6_S07                                 \ S07
$00000100 constant LCD_RAM_COM6_S08                                 \ S08
$00000200 constant LCD_RAM_COM6_S09                                 \ S09
$00000400 constant LCD_RAM_COM6_S10                                 \ S10
$00000800 constant LCD_RAM_COM6_S11                                 \ S11
$00001000 constant LCD_RAM_COM6_S12                                 \ S12
$00002000 constant LCD_RAM_COM6_S13                                 \ S13
$00004000 constant LCD_RAM_COM6_S14                                 \ S14
$00008000 constant LCD_RAM_COM6_S15                                 \ S15
$00010000 constant LCD_RAM_COM6_S16                                 \ S16
$00020000 constant LCD_RAM_COM6_S17                                 \ S17
$00040000 constant LCD_RAM_COM6_S18                                 \ S18
$00080000 constant LCD_RAM_COM6_S19                                 \ S19
$00100000 constant LCD_RAM_COM6_S20                                 \ S20
$00200000 constant LCD_RAM_COM6_S21                                 \ S21
$00400000 constant LCD_RAM_COM6_S22                                 \ S22
$00800000 constant LCD_RAM_COM6_S23                                 \ S23
$01000000 constant LCD_RAM_COM6_S24                                 \ S24
$02000000 constant LCD_RAM_COM6_S25                                 \ S25
$04000000 constant LCD_RAM_COM6_S26                                 \ S26
$08000000 constant LCD_RAM_COM6_S27                                 \ S27
$10000000 constant LCD_RAM_COM6_S28                                 \ S28
$20000000 constant LCD_RAM_COM6_S29                                 \ S29
$40000000 constant LCD_RAM_COM6_S30                                 \ S30
$80000000 constant LCD_RAM_COM6_S31                                 \ S31


\
\ @brief display memory
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM7_S00                                 \ S00
$00000002 constant LCD_RAM_COM7_S01                                 \ S01
$00000004 constant LCD_RAM_COM7_S02                                 \ S02
$00000008 constant LCD_RAM_COM7_S03                                 \ S03
$00000010 constant LCD_RAM_COM7_S04                                 \ S04
$00000020 constant LCD_RAM_COM7_S05                                 \ S05
$00000040 constant LCD_RAM_COM7_S06                                 \ S06
$00000080 constant LCD_RAM_COM7_S07                                 \ S07
$00000100 constant LCD_RAM_COM7_S08                                 \ S08
$00000200 constant LCD_RAM_COM7_S09                                 \ S09
$00000400 constant LCD_RAM_COM7_S10                                 \ S10
$00000800 constant LCD_RAM_COM7_S11                                 \ S11
$00001000 constant LCD_RAM_COM7_S12                                 \ S12
$00002000 constant LCD_RAM_COM7_S13                                 \ S13
$00004000 constant LCD_RAM_COM7_S14                                 \ S14
$00008000 constant LCD_RAM_COM7_S15                                 \ S15
$00010000 constant LCD_RAM_COM7_S16                                 \ S16
$00020000 constant LCD_RAM_COM7_S17                                 \ S17
$00040000 constant LCD_RAM_COM7_S18                                 \ S18
$00080000 constant LCD_RAM_COM7_S19                                 \ S19
$00100000 constant LCD_RAM_COM7_S20                                 \ S20
$00200000 constant LCD_RAM_COM7_S21                                 \ S21
$00400000 constant LCD_RAM_COM7_S22                                 \ S22
$00800000 constant LCD_RAM_COM7_S23                                 \ S23
$01000000 constant LCD_RAM_COM7_S24                                 \ S24
$02000000 constant LCD_RAM_COM7_S25                                 \ S25
$04000000 constant LCD_RAM_COM7_S26                                 \ S26
$08000000 constant LCD_RAM_COM7_S27                                 \ S27
$10000000 constant LCD_RAM_COM7_S28                                 \ S28
$20000000 constant LCD_RAM_COM7_S29                                 \ S29
$40000000 constant LCD_RAM_COM7_S30                                 \ S30
$80000000 constant LCD_RAM_COM7_S31                                 \ S31


\
\ @brief Liquid crystal display controller
\
$40002400 constant LCD_CR         \ offset: 0x00 : control register
$40002404 constant LCD_FCR        \ offset: 0x04 : frame control register
$40002408 constant LCD_SR         \ offset: 0x08 : status register
$4000240c constant LCD_CLR        \ offset: 0x0C : clear register
$40002414 constant LCD_RAM_COM0   \ offset: 0x14 : display memory
$4000241c constant LCD_RAM_COM1   \ offset: 0x1C : display memory
$40002424 constant LCD_RAM_COM2   \ offset: 0x24 : display memory
$4000242c constant LCD_RAM_COM3   \ offset: 0x2C : display memory
$40002434 constant LCD_RAM_COM4   \ offset: 0x34 : display memory
$4000243c constant LCD_RAM_COM5   \ offset: 0x3C : display memory
$40002444 constant LCD_RAM_COM6   \ offset: 0x44 : display memory
$4000244c constant LCD_RAM_COM7   \ offset: 0x4C : display memory

